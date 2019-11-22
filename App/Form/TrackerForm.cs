using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kyozy.MiniblinkNet;
using Newtonsoft.Json;

namespace App
{
    public partial class TrackerForm : Form
    {
        private WebView WebView;
        private string ext_js = "";
        private string Tracker_Id = "";
        private MainForm mainForm;

        internal bool Loaded { get; set; } = false;

        public TrackerForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            WebView = new WebView();
            InitializeComponent();
        }

        private void TrackerForm_Load(object sender, EventArgs e)
        {
            Loaded = true;
            ApplyLanguage();
            try
            {
                if (!WebView.Bind(pictureBox1))
                {
                    return;
                }
            }
            catch (Exception)
            {
                if (File.Exists("node.dll"))
                {
                    File.Delete("node.dll");
                }
                if (File.Exists($@"{Environment.GetEnvironmentVariable("windir")}\node.dll"))
                {
                    File.Delete($@"{Environment.GetEnvironmentVariable("windir")}\node.dll");
                }
                Log.Debug("Debug：删除已过期组件 node.dll");
                if (File.Exists($"node_{Global.NODE_NEED}.dll"))
                {
                    File.Move($"node_{Global.NODE_NEED}.dll", $@"{Environment.GetEnvironmentVariable("windir")}\node.dll");
                    Settings.NodeVersion = Global.NODE_NEED;
                }
                else if (File.Exists($@"{Environment.GetEnvironmentVariable("windir")}\node_{Global.NODE_NEED}.dll"))
                {
                    File.Move($@"{Environment.GetEnvironmentVariable("windir")}\node_{Global.NODE_NEED}.dll", $@"{Environment.GetEnvironmentVariable("windir")}\node.dll");
                    Settings.NodeVersion = Global.NODE_NEED;
                }
                else
                {
                    Settings.NodeVersion = 0;
                }
                Settings.Save();
                mainForm.tracker_disable();
                mainForm.ShowNotification("notification-dll-invalid", "node.dll", Localization.GetText("ui-settings-tracker"));
                return;
            }
            WebView.OnDocumentReady += OnDocumentReady;
            WebView.OnURLChange += OnURLChange;
            WebView.OnAlertBox += OnAlertBox;
            WebView.OnConfirmBox += OnConfirmBox;
        }


        private void OnAlertBox(object sender, AlertBoxEventArgs e)
        {
            LMessageBox.Alert(e.Msg);
        }

        private void OnConfirmBox(object sender, ConfirmBoxEventArgs e)
        {
            var respond = LMessageBox.Confirm(e.Msg, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2);
            e.Result = respond == DialogResult.Yes;
        }

        private void OnURLChange(object sender, UrlChangeEventArgs e)
        {
            if(e.URL!= $"{_TrackerHost()}{Tracker_Id}")
            {
                WebView.GoBack();
            }
        }

        internal void Tracker_Load(string Tracker_Id)
        {
            this.Invoke(() =>
            {
                this.Tracker_Id = Tracker_Id;
                toolStripTextBox_Tracker_Id.Text = Tracker_Id;
                WebView.LoadURL($@"{_TrackerHost()}{Tracker_Id}");
            });
        }


        private void OnDocumentReady(object sender, DocumentReadyEventArgs e)
        {
            WebView.RunJS("var clearcss = window.document.createElement('style');clearcss.innerHTML = '.clock,.time-format-selector,.logo-brand,.landing-page__container,.__1da0e,.mr-3 div:last-of-type,.export-icons {display:none;!important}';window.document.head.appendChild(clearcss);"); //clearcss
            if (ext_js != null)
            {
                WebView.RunJS(ext_js);
                ext_js = null;
                WebView.Reload();
            }
        }
        
        private void toolStripButton_Go_Click(object sender, EventArgs e)
        {
            Tracker_Load(toolStripTextBox_Tracker_Id.Text);
        }
        

        internal void set_nm_killed(ushort fateid)
        {
            if (!Loaded)
            {
                return;
            }
            string nmid = "";
            switch (fateid)
            {
                //Anemos
                case 1332:
                    nmid = "0";
                    break;

                case 1348:
                    nmid = "1";
                    break;

                case 1333:
                    nmid = "2";
                    break;

                case 1328:
                    nmid = "3";
                    break;

                case 1344:
                    nmid = "4";
                    break;

                case 1347:
                    nmid = "5";
                    break;

                case 1345:
                    nmid = "6";
                    break;

                case 1334:
                    nmid = "7";
                    break;

                case 1335:
                    nmid = "8";
                    break;

                case 1336:
                    nmid = "9";
                    break;

                case 1339:
                    nmid = "10";
                    break;

                case 1346:
                    nmid = "11";
                    break;

                case 1343:
                    nmid = "12";
                    break;

                case 1337:
                    nmid = "13";
                    break;

                case 1342:
                    nmid = "14";
                    break;

                case 1341:
                    nmid = "15";
                    break;

                case 1331:
                    nmid = "16";
                    break;

                case 1340:
                    nmid = "17";
                    break;

                case 1338:
                    nmid = "18";
                    break;

                case 1329:
                    nmid = "19";
                    break;

                //Pagos
                case 1351:
                    nmid = "0";
                    break;

                case 1369:
                    nmid = "1";
                    break;

                case 1353:
                    nmid = "2";
                    break;

                case 1354:
                    nmid = "3";
                    break;

                case 1355:
                    nmid = "4";
                    break;

                case 1366:
                    nmid = "5";
                    break;

                case 1357:
                    nmid = "6";
                    break;

                case 1356:
                    nmid = "7";
                    break;

                case 1352:
                    nmid = "8";
                    break;

                case 1360:
                    nmid = "9";
                    break;

                case 1358:
                    nmid = "10";
                    break;

                case 1361:
                    nmid = "11";
                    break;

                case 1362:
                    nmid = "12";
                    break;

                case 1359:
                    nmid = "13";
                    break;

                case 1363:
                    nmid = "14";
                    break;

                case 1365:
                    nmid = "15";
                    break;

                case 1364:
                    nmid = "16";
                    break;

                //Pyros
                case 1388:
                    nmid = "0";
                    break;

                case 1389:
                    nmid = "1";
                    break;

                case 1390:
                    nmid = "2";
                    break;

                case 1391:
                    nmid = "3";
                    break;

                case 1392:
                    nmid = "4";
                    break;

                case 1393:
                    nmid = "5";
                    break;

                case 1394:
                    nmid = "6";
                    break;

                case 1395:
                    nmid = "7";
                    break;

                case 1396:
                    nmid = "8";
                    break;

                case 1397:
                    nmid = "9";
                    break;

                case 1398:
                    nmid = "10";
                    break;

                case 1399:
                    nmid = "11";
                    break;

                case 1400:
                    nmid = "12";
                    break;

                case 1401:
                    nmid = "13";
                    break;

                case 1402:
                    nmid = "14";
                    break;

                case 1403:
                    nmid = "15";
                    break;

                case 1404:
                    nmid = "16";
                    break;

                //Hydatos
                case 1412:
                    nmid = "0";
                    break;

                case 1413:
                    nmid = "1";
                    break;

                case 1414:
                    nmid = "2";
                    break;

                case 1415:
                    nmid = "3";
                    break;

                case 1416:
                    nmid = "4";
                    break;

                case 1417:
                    nmid = "5";
                    break;

                case 1418:
                    nmid = "6";
                    break;

                case 1419:
                    nmid = "7";
                    break;

                case 1420:
                    nmid = "8";
                    break;

                case 1421:
                    nmid = "9";
                    break;

                case 1423:
                    nmid = "10";
                    break;

                default:
                    return;
            }
            this.Invoke(() =>
            {
                WebView.RunJS($@"if(document.querySelectorAll('.nm-table > div.ember-view')[{nmid}].classList.contains('killed'))document.querySelectorAll('.nm-table > div.ember-view')[{nmid}].querySelector('input.btn').click();document.querySelectorAll('.nm-table > div.ember-view')[{nmid}].querySelector('input.btn').click();");
            });
        }

        internal void ApplyLanguage()
        {
            if (!Loaded)
            {
                return;
            }
            this.Invoke(() =>
            {
                this.Text = Localization.GetText("tracker-title");
                toolStripButton_NT.Text = Localization.GetText("tracker-new-tracker");
                anemosToolStripMenuItem.Text = Localization.GetText("tracker-anemos");
                pagosToolStripMenuItem.Text = Localization.GetText("tracker-pagos");
                pyrosToolStripMenuItem.Text = Localization.GetText("tracker-pyros");
                hydatostoolStripMenuItem.Text = Localization.GetText("tracker-hydatos");
            });
        }

        private void TrackerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WebView.Dispose();
        }

        private void TrackerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && mainForm.TrackerFormLoaded) 
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void anemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_tracker(1);
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_tracker(2);
        }

        private void pyrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_tracker(3);
        }

        private void hydatostoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_tracker(4);
        }

        internal void new_tracker(int type)
        {
            Task.Factory.StartNew(() =>
            {
                this.Invoke(() =>
                {
                    Show();
                    var resp = WebApi.Post($@"{_TrackerHost()}api/instances", "{\"data\":{\"attributes\":{\"copy-from\":null,\"data-center-id\":null,\"instance-id\":null,\"created-at\":null,\"updated-at\":null,\"zone-id\":\"" + type.ToString() + "\"},\"type\":\"instances\"}}");
                    var json = JsonConvert.DeserializeObject<dynamic>(resp);
                    if (json.data.id != null)
                    {
                        Tracker_Load(json.data.id.ToString());
                        ext_js = $"localStorage.setItem('instancepw:{json.data.id.ToString()}','{json.data.attributes.password.ToString()}')";
                        Log.Debug($"Debug：New Tracker[Tracker_Id:{json.data.id.ToString()},Password:{json.data.attributes.password.ToString()}]");
                    }
                    else
                    {
                        LMessageBox.E("ui-new-tracker-error");
                    }
                });
            });
        }

        private void TrackerForm_Shown(object sender, EventArgs e)
        {
            Hide();
            Opacity = 1;
        }

        private string _TrackerHost()
        {
            string host;
            switch (Settings.TrackerMirror)
            {
                case "cn":
                    host = @"https://eureka.bluefissure.com/";
                    break;

                default:
                    host = @"https://ffxiv-eureka.com/";
                    break;
            }
            return host;
        }

        internal void Display()
        {
            this.Invoke(() =>
            {
                Show();
                TopMost = true;
                TopMost = false;
            });
        }
    }
}
