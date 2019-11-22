using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace App
{
    internal class Settings
    {
        private static INIFile iniFile;

        public static bool Crack { get; set; } = false;
        public static bool FirstRun { get; set; } = true;
        public static string dfaUpdate { get; set; } = "1";
        public static string dataUpdate { get; set; } = "1";
        public static string Language { get; set; } = "zh-cn";
        public static bool ShowOverlay { get; set; } = true;
        public static int OverlayX { get; set; } = Global.OVERLAY_XY_UNSET;
        public static int OverlayY { get; set; } = Global.OVERLAY_XY_UNSET;
        public static bool StartupShowMainForm { get; set; } = true;
        public static bool AutoOverlayHide { get; set; } = true;
        public static bool FlashWindow { get; set; } = true;
        public static bool CheatRoulette { get; set; } = false;
        public static bool HeartBeatLock { get; set; } = false;
        public static bool RouletteTips { get; set; } = true;
        public static bool Updated { get; set; } = true;
        public static bool PlaySound { get; set; } = false;
        public static bool TTS { get; set; } = false;
        public static string TTSCache { get; set; } = "1";
        public static string TTSSpeed { get; set; } = "4";
        public static int TTSVol { get; set; } = 100;
        public static bool DebugLog { get; set; } = false;
        public static bool NetFilter { get; set; } = false;
        public static string SoundLocation { get; set; } = "";
        public static HashSet<int> FATEs { get; set; } = new HashSet<int>();
        public static bool AutoTracker { get; set; } = true;
        public static bool TrackerEnabled { get; set; } = true;
        public static string TrackerMirror { get; set; } = "0";
        public static bool CheckBeta { get; set; } = false;
        public static int NodeVersion = 0;

        private static void Init()
        {
        }

        public static void Load()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, Global.SETTINGS_FILEPATH);

            iniFile = new INIFile(path);
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                Init();
                Save();
            }
            else
            {
                Crack = iniFile.ReadValue("crack", "crack") == "1";
                FirstRun = iniFile.ReadValue("internal", "firstrun") != "0";
                StartupShowMainForm = iniFile.ReadValue("startup", "show") != "0";
                ShowOverlay = iniFile.ReadValue("overlay", "show") != "0";
                AutoOverlayHide = iniFile.ReadValue("overlay", "autohide") != "0";
                OverlayX = int.Parse(iniFile.ReadValue("overlay", "x") ?? "0");
                OverlayY = int.Parse(iniFile.ReadValue("overlay", "y") ?? "0");
                FlashWindow = iniFile.ReadValue("notification", "flashwindow") != "0";
                CheatRoulette = iniFile.ReadValue("misc", "cheatroulette") == "1";
                HeartBeatLock = iniFile.ReadValue("misc", "heartbeatlock") == "1";
                RouletteTips = iniFile.ReadValue("misc", "roulettetips") != "0";
                Language = iniFile.ReadValue("misc", "language") ?? "zh-cn";
                dfaUpdate = iniFile.ReadValue("update", "dfaupdate") ?? "1";
                dataUpdate = iniFile.ReadValue("update", "dataupdate") ?? "1";
                CheckBeta = iniFile.ReadValue("update", "checkbeta") == "1";
                Updated = iniFile.ReadValue("internal", "updated") != "0";
                PlaySound = iniFile.ReadValue("notification", "playsound") == "1";
                TTS = iniFile.ReadValue("notification", "tts") == "1";
                TTSCache = iniFile.ReadValue("notification", "ttscache") ?? "1";
                TTSSpeed = iniFile.ReadValue("notification", "ttsspeed") ?? "4";
                TTSVol = int.Parse(iniFile.ReadValue("notification", "ttsvol") ?? "100");
                DebugLog = iniFile.ReadValue("dev", "debuglog") == "1";
                NetFilter = iniFile.ReadValue("dev", "netfilter") == "1";
                SoundLocation = iniFile.ReadValue("notification", "soundlocation") ?? "";
                TrackerEnabled = iniFile.ReadValue("tracker", "trackerenabled") != "0";
                TrackerMirror = iniFile.ReadValue("tracker", "trackermirror") ?? "cn"; 
                AutoTracker = iniFile.ReadValue("tracker", "autotracker") != "0";
                NodeVersion= int.Parse(iniFile.ReadValue("dll", "node") ?? "0");

                var fates = iniFile.ReadValue("fate", "fates");
                if (!string.IsNullOrEmpty(fates))
                {
                    FATEs = new HashSet<int>(from x in fates.Split(',') select int.Parse(x));
                }
            }
        }

        public static void Save()
        {
            iniFile.WriteValue("crack", "crack", Crack ? "1" : "0");
            iniFile.WriteValue("internal", "firstrun", FirstRun ? "1" : "0");
            iniFile.WriteValue("startup", "show", StartupShowMainForm ? "1" : "0");
            iniFile.WriteValue("overlay", "show", ShowOverlay ? "1" : "0");
            iniFile.WriteValue("overlay", "autohide", AutoOverlayHide ? "1" : "0");
            iniFile.WriteValue("overlay", "x", OverlayX.ToString());
            iniFile.WriteValue("overlay", "y", OverlayY.ToString());
            iniFile.WriteValue("notification", "flashwindow", FlashWindow ? "1" : "0");
            iniFile.WriteValue("misc", "cheatroulette", CheatRoulette ? "1" : "0");
            iniFile.WriteValue("misc", "heartbeatlock", HeartBeatLock ? "1" : "0");
            iniFile.WriteValue("misc", "roulettetips", RouletteTips ? "1" : "0");
            iniFile.WriteValue("misc", "language", Language);
            iniFile.WriteValue("update", "dfaupdate", dfaUpdate);
            iniFile.WriteValue("update", "dataupdate", dataUpdate);
            iniFile.WriteValue("update", "checkbeta", CheckBeta ? "1" : "0");
            iniFile.WriteValue("fate", "fates", string.Join(",", FATEs));
            iniFile.WriteValue("internal", "updated", Updated ? "1" : "0");
            iniFile.WriteValue("notification", "playsound", PlaySound ? "1" : "0");
            iniFile.WriteValue("notification", "tts", TTS ? "1" : "0");
            iniFile.WriteValue("notification", "ttscache", TTSCache);
            iniFile.WriteValue("notification", "ttsspeed", TTSSpeed);
            iniFile.WriteValue("notification", "ttsvol", TTSVol.ToString());
            iniFile.WriteValue("dev", "debuglog", DebugLog ? "1" : "0");
            iniFile.WriteValue("dev", "netfilter", NetFilter ? "1" : "0");
            iniFile.WriteValue("notification", "soundlocation", SoundLocation);
            iniFile.WriteValue("tracker", "trackerenabled", TrackerEnabled ? "1" : "0");
            iniFile.WriteValue("tracker", "trackermirror",TrackerMirror);
            iniFile.WriteValue("tracker", "autotracker", AutoTracker ? "1" : "0");
            iniFile.WriteValue("dll", "node", NodeVersion.ToString());
        }
    }
}
