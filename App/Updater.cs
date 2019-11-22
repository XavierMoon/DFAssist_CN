using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace App
{
    internal class Updater
    {
        internal static void CheckNewVersion(MainForm mainForm, bool force = false, bool backstable = false)
        {
            Task.Factory.StartNew(() =>
            {
                var tempdir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, Global.UPDATE_TEMP_DIRPATH);
                var batchpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, "update.bat");

                if (Directory.Exists(tempdir))
                {
                    Directory.Delete(tempdir, true);
                }
                Directory.CreateDirectory(tempdir);

                var resp = WebApi.Request("http://ffxiv.diemoe.net/DFA/check_update.php");
                if (resp == null)
                {
                    Log.E("l-updater-error-check");
                    return;
                }

                try
                {
                    var api = JsonConvert.DeserializeObject<dynamic>(resp);

                    var latest_stable = api.tag_name.ToObject<string>();
                    var latest_beta = api.tag_name_beta.ToObject<string>();
                    var latest = Settings.CheckBeta ? latest_beta : latest_stable;
                    Log.I("l-updater-current-version", Global.VERSION);
                    Log.I("l-updater-latest-version", latest);
                    var ci = new CultureInfo("en-us");
                    if ((decimal.Parse(Global.VERSION.Substring(1), ci) >= decimal.Parse(latest.Substring(1), ci)) && !(!Settings.CheckBeta && backstable && latest_stable != latest_beta)) 
                    {
                        Log.S("l-updater-is-latest");
                        if(force)
                        {
                            mainForm.ShowNotification("notification-update-latest");
                        }
                    }
                    else
                    {
                        Log.S("l-updater-new-version");
                        string doUpdate;
                        if (force)
                        {
                            doUpdate = "1";
                            mainForm.ShowNotification("notification-uptodate", latest);
                        }
                        else
                        {
                            doUpdate = Settings.dfaUpdate;
                        }
                        switch (doUpdate)
                        {
                            case "0":

                                break;

                            case "1"://auto update
                                mainForm.ShowNotification("notification-uptodate", latest);
                                string url = Settings.CheckBeta ? api.url_beta.ToObject<string>() : api.url.ToObject<string>();

                                if (url == null)
                                {
                                    Log.E("l-updater-error-no-url");
                                    return;
                                }

                                if (mainForm.TrackerFormLoaded)
                                {
                                    mainForm.tracker_close();
                                }
                                mainForm.Invoke(() =>
                                {
                                    mainForm.Hide();
                                    mainForm.overlayForm.Hide();
                                });

                                Task.Factory.StartNew(() =>
                                {
                                    var updaterForm = new UpdaterForm();
                                    updaterForm.SetVersion(latest);
                                    updaterForm.ShowDialog();
                                });

                                //Sentry.Report("Update started");

                                var exepath = Process.GetCurrentProcess().MainModule.FileName;

                                var stream = GetDownloadStreamByUrl(url);
                                using (var zip = ZipStorer.Open(stream, FileAccess.Read))
                                {
                                    var dir = zip.ReadCentralDir();
                                    foreach (var entry in dir)
                                    {
                                        /*
                                        if (entry.FilenameInZip == "README.txt")
                                        {
                                            continue;
                                        }
                                        */

                                        var filename = entry.FilenameInZip;
                                        if (filename == "DFAssist.exe")
                                        {
                                            filename = Path.GetFileName(exepath);
                                        }

                                        zip.ExtractFile(entry, Path.Combine(tempdir, filename));
                                    }
                                }

                                var currentdir = Path.GetDirectoryName(exepath);

                                File.WriteAllText(batchpath,
                                    "@echo off\r\n" +
                                    "title DFAssist Updater\r\n" +
                                    "echo Updating DFAssist...\r\n" +
                                    "ping 127.0.0.1 -n 3 > nul\r\n" +
                                    $"move /y \"{tempdir}*\" \"{currentdir}\" > nul\r\n" +
                                    $"\"{exepath}\"\r\n" +
                                    "echo Running DFAssist...\r\n",
                                Encoding.Default);

                                var si = new ProcessStartInfo();
                                si.FileName = batchpath;
                                si.CreateNoWindow = true;
                                si.UseShellExecute = false;
                                si.WindowStyle = ProcessWindowStyle.Hidden;

                                Process.Start(si);
                                Settings.Updated = true;
                                Settings.Save();
                                Application.Exit();
                                break;

                            case "2":
                                mainForm.ShowNotification("notification-update-enabled",latest);
                                break;

                            default:
                                break;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    Log.Ex(ex, "l-updater-error-general");
                }
                if (Settings.dataUpdate=="1")
                {
                    try
                    {
                        var json = WebApi.Request($"http://ffxiv.diemoe.net/DFA/Data/{Settings.Language}.json");
                        Data.Fill(json, mainForm);
                    }
                    catch (Exception ex)
                    {
                        Log.Ex(ex, "l-updater-error-data");
                    }
                }
                if (force)
                {
                    mainForm.button_update_enabled();
                }
            });
        }

        private static Stream GetDownloadStreamByUrl(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "DFA";
                request.Timeout = 20000;

                var response = (HttpWebResponse)request.GetResponse();
                var stream = new MemoryStream();

                response.GetResponseStream().CopyTo(stream);
                return stream;
            }
            catch (Exception ex)
            {
                Log.Ex(ex, "l-updater-error-downloading");
            }

            return null;
        }
    }
}
