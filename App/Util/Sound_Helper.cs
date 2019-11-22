using System;
using System.IO;
using System.Runtime.InteropServices;

namespace App
{
    internal static class Sound_Helper
    {
        internal static void Play(string FilePath, string Alias = "media",int Volume = 1000)
        {
            try
            {
                mciSendString($"close {Alias}", "", 0, 0);
                mciSendString($"open {FilePath} alias {Alias}", "", 0, 0);
                mciSendString($"setaudio {Alias} volume to {Volume}", "", 0, 0);
                mciSendString($"play {Alias}", "", 0, 0);
            }
            catch (Exception ex)
            {
                Log.Ex(ex, "l-soundhelper-error-general");
            }
        }
        internal static void TTS_ClearCache()
        {
            try
            {
                if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, "tts_cache")))
                {
                    Stop("TTS");
                    Directory.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, "tts_cache"), true);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        internal static void TTS(string text, string localization="zh")
        {
            string tts = System.Web.HttpUtility.UrlEncode(text, System.Text.Encoding.UTF8);
            string tmp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, "tts_cache", $"{localization}_{tts}.mp3");
            if (File.Exists(tmp) && Settings.TTSCache=="0")
            {
                WebApi.Download($"https://fanyi.baidu.com/gettts?lan={localization}&text={tts}&spd={Settings.TTSSpeed}&source=web", tmp, true);
            }
            else if(!File.Exists(tmp))
            {
                WebApi.Download($"https://fanyi.baidu.com/gettts?lan={localization}&text={tts}&spd={Settings.TTSSpeed}&source=web", tmp);
            }
            Play(tmp,"TTS",Settings.TTSVol * 10);
        }

        internal static void Pause(string Alias = "media")
        {
            mciSendString($"pause {Alias}", "", 0, 0);
        }
        
        internal static void Stop(string Alias = "media")
        {
            mciSendString($"close {Alias}", "", 0, 0);
        }
        
        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        private static extern int mciSendString(
         string lpstrCommand,
         string lpstrReturnString,
         int uReturnLength,
         int hwndCallback
        );
    }
}
