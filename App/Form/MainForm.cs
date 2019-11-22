using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        internal Network networkWorker;
        internal Process FFXIVProcess;
        internal OverlayForm overlayForm;
        internal TrackerForm TrackerForm;
        internal TipsForm tipsForm;
        internal List<TreeNode> nodes;
        internal bool TrackerFormLoaded = false;

        public MainForm()
        {
            Settings.Load();
            if (Settings.FirstRun)
            {
                LMessageBox.Alert("本软件完全免费，仅供学习交流使用，禁止倒卖。\n如果您是通过闲鱼、拼多多、淘宝等平台购买到本软件，请立即退货并差评！\nDFAssist_CN 中文支持版唯一指定官网 http://ffxiv.diemoe.net/");
                Settings.FirstRun = false;
            }
            InitializeComponent();
            Log.Form = this;
            overlayForm = new OverlayForm(this);
            nodes = new List<TreeNode>();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!Settings.StartupShowMainForm)
            {
                Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Localization.Initialize(Settings.Language);
            Data.Initialize(Settings.Language, this);
            ApplyLanguage();
            overlayForm.Show();
            networkWorker = new Network(this);
            label_AboutTitle.Text = $@"DFA {Global.VERSION}_CN";
            if (Settings.Updated)
            {
                if (Settings.CheatRoulette)
                {
                    Settings.Crack = true;
                }
                Settings.Updated = false;
                Settings.Save();
                Log.S("notification-app-updated", Global.VERSION);
                ShowNotification("notification-app-updated", Global.VERSION);
            }
            if (Settings.Crack)
            {
                this.Text += " 至尊无敌豪华SVIP高级功能破解版";
                label_AboutTitle.Text += "_Crack";
                checkBox_CheatRoullete.Enabled = checkBox_HeartBeatLock.Enabled = true;
            }
            FindFFXIVProcess();
            
            if (Settings.NodeVersion < Global.NODE_NEED)
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
                    Settings.Save();
                }
                else if (File.Exists($@"{Environment.GetEnvironmentVariable("windir")}\node_{Global.NODE_NEED}.dll"))
                {
                    File.Move($@"{Environment.GetEnvironmentVariable("windir")}\node_{Global.NODE_NEED}.dll", $@"{Environment.GetEnvironmentVariable("windir")}\node.dll");
                    Settings.NodeVersion = Global.NODE_NEED;
                    Settings.Save();
                }
            }
            if (!Settings.ShowOverlay)
            {
                checkBox_Overlay.Checked = false;
            }
            overlayForm.tryHide();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Updater.CheckNewVersion(this);
                    if (Settings.HeartBeatLock)
                    {
                        WinApi.PostF24(FFXIVProcess);
                    }
                    Thread.Sleep(15 * 60 * 1000);
                }
            });

            comboBox_Language.DataSource = new[]
            {
                new SelectedItem { Name = "한국어", Code = "ko-kr" },
                new SelectedItem { Name = "English", Code = "en-us" },
                new SelectedItem { Name = "Français", Code = "fr-fr" },
                new SelectedItem { Name = "日本語", Code = "ja-jp" },
                new SelectedItem { Name = "简体中文", Code = "zh-cn" },
            };

            comboBox_Language.DisplayMember = "Name";
            comboBox_Language.ValueMember = "Code";

            comboBox_Language.SelectedValue = Settings.Language;

            comboBox_Language.SelectedValueChanged += comboBox_Language_SelectedValueChanged;

            checkBox_StartupShow.Checked = Settings.StartupShowMainForm;
            checkBox_AutoOverlayHide.Checked = Settings.AutoOverlayHide;
            checkBox_FlashWindow.Checked = Settings.FlashWindow;
            checkBox_PlaySound.Checked = Settings.PlaySound;
            if (Settings.TrackerMirror == "cn")
            {
                checkBox_tracker_CNmirror.Checked = true;
            }
            trackBar_tts_speed.Value = int.Parse(Settings.TTSSpeed);
            textBox_tts_speed.Text = Settings.TTSSpeed;
            trackBar_tts_vol.Value = Settings.TTSVol;
            textBox_tts_vol.Text = Settings.TTSVol.ToString();
            if (File.Exists(Settings.SoundLocation) == false)
            {
                checkBox_PlaySound.Checked = false;
                label_SoundLocation.Text = "";
            }
            else
            {
                label_SoundLocation.Text = Path.GetFileName(Settings.SoundLocation);
            }
            if (checkBox_PlaySound.Checked == false) { button_SoundLocation.Enabled = button_Sound_Stop.Enabled = false; }
            SetCheatRoulleteCheckBox(Settings.CheatRoulette);
            checkBox_HeartBeatLock.Checked = Settings.HeartBeatLock;
            checkBox_HeartBeatLock.CheckedChanged += checkBox_HeartBeatLock_CheckedChanged;
            checkBox_RoulleteTips.Checked = Settings.RouletteTips;

            checkBox_TTS.Checked = Settings.TTS;
            checkBox_DevMode.Checked = Settings.DebugLog;
            checkBox_netFilter.Checked = Settings.NetFilter;
            checkBox_tracker_enabled.Checked = Settings.TrackerEnabled;
            checkBox_tracker_auto.Checked = Settings.AutoTracker;
            checkBox_UpdateCheckBeta.Checked = Settings.CheckBeta;

            Update_FATENodes();

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(30 * 1000);

                    if (FFXIVProcess == null || FFXIVProcess.HasExited)
                    {
                        FFXIVProcess = null;

                        overlayForm.SetStatus(false);
                        this.Invoke(FindFFXIVProcess);
                    }
                    else {
                        // FFXIVProcess is alive

                        if (networkWorker.IsRunning)
                        {
                            networkWorker.UpdateGameConnections(FFXIVProcess);
                        }
                        else
                        {
                            networkWorker.StartCapture(FFXIVProcess);
                        }
                    }
                }
            });
            Log.Echo("DFAssist_CN 中文支持版，开发：<中国区> 呆萌@红玉海。");
            Log.Echo("本程序永久免费，请勿用于商业用途。");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void toolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Log.SelectionStart = richTextBox_Log.Text.Length;
            richTextBox_Log.SelectionLength = 0;
            richTextBox_Log.ScrollToCaret();
        }

        private void linkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://github.com/{Global.GITHUB_REPO}");
        }

        private void linkLabel_NewUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://github.com/{Global.GITHUB_REPO}/releases/latest");
        }

        private void button_SelectProcess_Click(object sender, EventArgs e)
        {
            try
            {
                SetFFXIVProcess(Process.GetProcessById(int.Parse(((string)comboBox_Process.SelectedItem).Split(':')[1])));
            }
            catch
            {
                Log.E("l-process-set-failed");
            }
        }

        private void button_ResetProcess_Click(object sender, EventArgs e)
        {
            networkWorker.StopCapture();
            FFXIVProcess = null;
            FindFFXIVProcess();
        }

        private void checkBox_Overlay_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ShowOverlay = checkBox_Overlay.Checked;
            Settings.Save();
            overlayForm.tryHide();
        }

        private void button_ResetOverlayPosition_Click(object sender, EventArgs e)
        {
            overlayForm.ResetFormLocation();
        }

        private void checkBox_StartupShow_CheckedChanged(object sender, EventArgs e)
        {
            Settings.StartupShowMainForm = checkBox_StartupShow.Checked;
            Settings.Save();
        }
        

        private void checkBox_AutoOverlayHide_CheckedChanged(object sender, EventArgs e)
        {
            Settings.AutoOverlayHide = checkBox_AutoOverlayHide.Checked;
            Settings.Save();
            overlayForm.tryHide();
        }

        private void checkBox_FlashWindow_CheckedChanged(object sender, EventArgs e)
        {
            Settings.FlashWindow = checkBox_FlashWindow.Checked;
            Settings.Save();
        }

        private void checkBox_CheatRoullete_CheckedChanged(object sender, EventArgs e)
        {
            var @checked = checkBox_CheatRoullete.Checked;
            SetCheatRoulleteCheckBox(false);
            if (@checked)
            {
                var respond = LMessageBox.W("ui-cheat-roulette-confirm", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2);
                if (respond == DialogResult.Yes)
                {
                    LMessageBox.I("ui-cheat-roulette-enabled");
                    SetCheatRoulleteCheckBox(true);
                }
            }

            Settings.CheatRoulette = checkBox_CheatRoullete.Checked;
            Settings.Save();
        }

        private void checkBox_HeartBeatLock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HeartBeatLock.Checked)
            {
                var respond = LMessageBox.W("ui-heart-beat-lock-confirm", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2);
                if (respond == DialogResult.Yes)
                {
                    LMessageBox.I("ui-heart-beat-lock-enabled");
                }
            }

            Settings.HeartBeatLock = checkBox_HeartBeatLock.Checked;
            Settings.Save();
        }

        private void toolStripMenuItem_LogCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox_Log.Text);
            LMessageBox.I("ui-clipboard-copied");
        }

        private void toolStripMenuItem_LogClear_Click(object sender, EventArgs e)
        {
            if (LMessageBox.I("ui-clear-log-confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                richTextBox_Log.Text = "";
            }
        }

        private void toolStripMenuItem_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (var node in nodes)
            {
                node.Checked = true;
                Settings.FATEs.Add(ushort.Parse(node.Name));
            }

            Settings.Save();
        }

        private void toolStripMenuItem_UnSelectAll_Click(object sender, EventArgs e)
        {
            FateAllUnset(true);
        }

        private void toolStripMenuItem_SelectApply_Click(object sender, EventArgs e)
        {
            foreach (var node in nodes)
            {
                if (node.Checked)
                {
                    Settings.FATEs.Add(ushort.Parse(node.Name));
                }
                else
                {
                    Settings.FATEs.Remove(ushort.Parse(node.Name));
                }
            }

            Settings.Save();
            LMessageBox.I("ui-fate-selection-saved");
        }

        private void FateAllUnset(bool save = false)
        {
            foreach (var node in nodes)
            {
                node.Checked = false;
            }

            Settings.FATEs.Clear();

            if (save)
                Settings.Save();
        }

        private void PresetAccept(int[] arr)
        {
            FateAllUnset();

            foreach (var node in nodes)
            {
                var c = ushort.Parse(node.Name);
                if (arr.Any(code => code == c))
                {
                    node.Checked = true;
                    Settings.FATEs.Add(c);
                }
            }

            Settings.Save();
            LMessageBox.I("ui-fate-preset-applied");
        }

        private void bookOfSkyfireIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 611, 480, 589 };
            PresetAccept(arr);
        }

        private void bookOfSkyfireIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 424, 633, 571 };
            PresetAccept(arr);
        }

        private void bookOfNetherfireIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 521, 620, 430 };
            PresetAccept(arr);
        }

        private void bookOfSkyfallIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 540, 577, 475 };
            PresetAccept(arr);
        }

        private void bookOfSkyfallIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 569, 616, 516 };
            PresetAccept(arr);
        }
        
        private void bookOfNetherfireIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] arr = { 632, 642, 499 };
            PresetAccept(arr);
        }

        private void bookOfSkywindIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 604, 317, 517 };
            PresetAccept(arr);
        }

        private void bookOfSkywindIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 552, 628, 486 };
            PresetAccept(arr);
        }

        private void bookOfSkyearthIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 543, 493, 587 };
            PresetAccept(arr);
        }

        private void IxionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 1103, 1104, 1105 };
            PresetAccept(arr);
        }

        private void TamamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = { 1106, 1107, 1108, 1109, 1110, 1111 };
            PresetAccept(arr);
        }

        private void SetCheatRoulleteCheckBox(bool @checked)
        {
            checkBox_CheatRoullete.CheckedChanged -= checkBox_CheatRoullete_CheckedChanged;
            checkBox_CheatRoullete.Checked = @checked;
            checkBox_CheatRoullete.CheckedChanged += checkBox_CheatRoullete_CheckedChanged;
        }

        private void FindFFXIVProcess()
        {
            comboBox_Process.Items.Clear();
            Log.I("l-process-finding");

            var processes = new List<Process>();
            processes.AddRange(Process.GetProcessesByName("ffxiv"));
            processes.AddRange(Process.GetProcessesByName("ffxiv_dx11"));

            if (processes.Count == 0)
            {
                Log.E("l-process-found-nothing");
                button_SelectProcess.Enabled = false;
                comboBox_Process.Enabled = false;
            }
            else if (processes.Count >= 2)
            {
                Log.E("l-process-found-multiple");
                button_SelectProcess.Enabled = true;
                comboBox_Process.Enabled = true;

                foreach (var process in processes)
                {
                    comboBox_Process.Items.Add($"{process.ProcessName}:{process.Id}");
                }
                comboBox_Process.SelectedIndex = 0;
            }
            else {
                SetFFXIVProcess(processes[0]);
            }
        }

        private void SetFFXIVProcess(Process process)
        {
            FFXIVProcess = process;

            var name = $"{FFXIVProcess.ProcessName}:{FFXIVProcess.Id}";
            Log.S("l-process-set-success", name);

            comboBox_Process.Enabled = false;
            button_SelectProcess.Enabled = false;

            comboBox_Process.Items.Clear();
            comboBox_Process.Items.Add(name);
            comboBox_Process.SelectedIndex = 0;

            networkWorker.StartCapture(FFXIVProcess);
        }

        internal void ShowNotification(string key, params object[] args)
        {
            this.Invoke(() =>
            {
                notifyIcon.ShowBalloonTip(10 * 1000, Localization.GetText("app-name"), Localization.GetText(key, args), ToolTipIcon.Info);
            });
        }

        private void comboBox_Language_SelectedValueChanged(object sender, EventArgs e)
        {
            var language = comboBox_Language.SelectedValue.ToString();
            if (Settings.Language == language)
            {
                return;
            }

            Settings.Language = language;
            Settings.Save();

            Localization.Initialize(Settings.Language);
            Data.Initialize(Settings.Language, this);

            ApplyLanguage();

            LMessageBox.I("ui-language-changed");
        }

        private void ApplyLanguage()
        {
            this.Text = Localization.GetText("app-name");
            notifyIcon.Text = Localization.GetText("app-name");
            toolStripMenuItem_Open.Text = Localization.GetText("ui-notifymenustrip-open");
            toolStripMenuItem_Close.Text = Localization.GetText("ui-notifymenustrip-close");
            label_Process.Text = Localization.GetText("ui-topsetting-process");
            button_SelectProcess.Text = Localization.GetText("ui-topsetting-select");
            button_ResetProcess.Text = Localization.GetText("ui-topsetting-reset");
            tabPage_Settings.Text = Localization.GetText("ui-tabcontrol-settings");
            tabPage_FATE.Text = Localization.GetText("ui-tabcontrol-fate");
            tabPage_Log.Text = Localization.GetText("ui-tabcontrol-logs");
            tabPage_devmode.Text = Localization.GetText("ui-tabcontrol-dev");
            tabPage_Info.Text = Localization.GetText("ui-tabcontrol-info");
            settings_basic.Text = Localization.GetText("ui-settings-title");
            groupBox_debug_settings.Text = Localization.GetText("ui-settings-debug");
            groupBox_network_settings.Text = Localization.GetText("ui-settings-network");
            checkBox_Overlay.Text = Localization.GetText("ui-settings-overlay-use");
            toolTip.SetToolTip(checkBox_Overlay, Localization.GetText("ui-settings-overlay-tooltip"));
            button_ResetOverlayPosition.Text = Localization.GetText("ui-settings-overlay-reset");
            checkBox_StartupShow.Text = Localization.GetText("ui-settings-startupshow");
            checkBox_AutoOverlayHide.Text = Localization.GetText("ui-settings-autohide");
            checkBox_FlashWindow.Text = Localization.GetText("ui-settings-iconflash");
            checkBox_PlaySound.Text = Localization.GetText("ui-settings-playsound");
            checkBox_TTS.Text = Localization.GetText("ui-settings-tts");
            checkBox_DevMode.Text = Localization.GetText("ui-settings-debuglog");
            checkBox_netFilter.Text = Localization.GetText("ui-settings-netfilter");
            button_SoundLocation.Text = Localization.GetText("ui-settings-soundlocation");
            button_Sound_Stop.Text = Localization.GetText("ui-settings-soundlocation-stop");
            checkBox_CheatRoullete.Text = Localization.GetText("ui-settings-cheatroulette");
            checkBox_HeartBeatLock.Text = Localization.GetText("ui-settings-heartbeatlock");
            checkBox_RoulleteTips.Text = Localization.GetText("ui-settings-roulettetips");
            tts_speed.SetLocalizedText("ui-settings-tts-speed");
            tts_vol.SetLocalizedText("ui-settings-tts-vol");
            tts_cache.SetLocalizedText("ui-settings-tts-cache");
            button_tts_clear_cache.Text = Localization.GetText("ui-settings-tts-cache-clear");
            button_tts_test.Text = Localization.GetText("ui-settings-tts-test");
            button_update.Text = Localization.GetText("ui-settings-update-manual");
            settings_tts.Text = Localization.GetText("ui-settings-tts-title");
            settings_advanced.Text = Localization.GetText("ui-settings-advanced-title");
            toolStripMenuItem_SelectAll.Text = Localization.GetText("ui-fate-selectall");
            toolStripMenuItem_UnSelectAll.Text = Localization.GetText("ui-fate-unselectall");
            presetToolStripMenuItem.Text = Localization.GetText("ui-fate-preset");
            bookOfSkyfireIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkyfireI");
            bookOfSkyfireIIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkyfireII");
            bookOfNetherfireIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-NetherfireI");
            bookOfSkyfallIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkyfallI");
            bookOfSkyfallIIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkyfallII");
            bookOfNetherfireIToolStripMenuItem1.Text = Localization.GetText("fate-preset-animus-NetherfallI");
            bookOfSkywindIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkywindI");
            bookOfSkywindIIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkywindII");
            bookOfSkyearthIToolStripMenuItem.Text = Localization.GetText("fate-preset-animus-SkyearthI");
            IxionToolStripMenuItem.Text = Localization.GetText("fate-preset-Ixion");
            TamamoToolStripMenuItem.Text = Localization.GetText("fate-preset-Tamamo");
            toolStripMenuItem_SelectApply.Text = Localization.GetText("ui-fate-apply");
            label_FATEAbout.Text = Localization.GetText("ui-fate-about");
            toolStripMenuItem_LogCopy.Text = Localization.GetText("ui-logs-copy");
            toolStripMenuItem_LogClear.Text = Localization.GetText("ui-logs-clear");
            label_About.Text = Localization.GetText("ui-info-about");
            settings_update.Text = Localization.GetText("ui-settings-update");
            update_about.SetLocalizedText("ui-settings-update-about");
            settings_eureka_tracker.Text = Localization.GetText("ui-settings-tracker");
            checkBox_tracker_enabled.Text = Localization.GetText("ui-settings-tracker-enabled");
            checkBox_tracker_auto.Text = Localization.GetText("ui-settings-tracker-auto");
            button_tracker_open.Text = Localization.GetText("ui-settings-tracker-open");
            checkBox_tracker_CNmirror.Text= Localization.GetText("ui-settings-tracker-mirror-cn");
            comboBox_dfaUpdate.SelectedValueChanged -= comboBox_dfaUpdate_SelectedValueChanged;
            comboBox_dfaUpdate.DataSource = new[]
            {
                new SelectedItem { Name = Localization.GetText("ui-settings-update-setting-auto"), Code = "1" },
                new SelectedItem { Name = Localization.GetText("ui-settings-update-setting-notification"), Code = "2" },
                new SelectedItem { Name = Localization.GetText("ui-settings-update-setting-no"), Code = "0" },
            };
            comboBox_dfaUpdate.DisplayMember = "Name";
            comboBox_dfaUpdate.ValueMember = "Code";
            comboBox_dfaUpdate.SelectedValue = Settings.dfaUpdate;
            update_data_about.SetLocalizedText("ui-settings-update-data-about");
            comboBox_dfaUpdate.SelectedValueChanged += comboBox_dfaUpdate_SelectedValueChanged;
            comboBox_dataUpdate.SelectedValueChanged -= comboBox_dataUpdate_SelectedValueChanged;
            comboBox_dataUpdate.DataSource = new[]
            {
                new SelectedItem { Name = Localization.GetText("ui-settings-update-data-setting-auto"), Code = "1" },
                new SelectedItem { Name = Localization.GetText("ui-settings-update-data-setting-no"), Code = "0" },
            };
            comboBox_dataUpdate.DisplayMember = "Name";
            comboBox_dataUpdate.ValueMember = "Code";
            comboBox_dataUpdate.SelectedValue = Settings.dataUpdate;
            comboBox_dataUpdate.SelectedValueChanged += comboBox_dataUpdate_SelectedValueChanged;
            comboBox_tts_cache.SelectedValueChanged -= comboBox_tts_cache_SelectedValueChanged;
            comboBox_tts_cache.DataSource = new[]
            {
                new SelectedItem { Name = Localization.GetText("ui-settings-tts-cache-use"), Code = "1" },
                new SelectedItem { Name = Localization.GetText("ui-settings-tts-cache-force"), Code = "2" },
                new SelectedItem { Name = Localization.GetText("ui-settings-tts-cache-nouse"), Code = "0" },
            };
            comboBox_tts_cache.DisplayMember = "Name";
            comboBox_tts_cache.ValueMember = "Code";
            comboBox_tts_cache.SelectedValue = Settings.TTSCache;
            comboBox_tts_cache.SelectedValueChanged += comboBox_tts_cache_SelectedValueChanged;
            checkBox_UpdateCheckBeta.Text = Localization.GetText("ui-settings-update-check-beta");
            if (TrackerFormLoaded)
            {
                TrackerForm.ApplyLanguage();
            }
        }

        internal void Update_FATENodes()
        {
            triStateTreeView_FATEs.Nodes.Clear();
            foreach (var area in Data.Areas)
            {
                triStateTreeView_FATEs.Nodes.Add(area.Key.ToString(), area.Value.Name);

                foreach (var fate in area.Value.FATEs)
                {
                    var node = triStateTreeView_FATEs.Nodes[area.Key.ToString()].Nodes.Add(fate.Key.ToString(), fate.Value.Name);
                    node.Checked = Settings.FATEs.Contains(fate.Key);
                    nodes.Add(node);
                }
            }
        }

        internal void Show_DutyTips(string Roullete, string Instance, string Tip, string Macro = null)
        {
            this.Invoke(() =>
            {
                if (tipsForm != null)
                {
                    tipsForm.Dispose();
                }
                tipsForm = new TipsForm(Roullete, Instance, Tip, Macro);
                tipsForm.Show();
            });
        }

        private void checkBox_PlaySound_CheckedChanged(object sender, EventArgs e)
        {
            button_SoundLocation.Enabled = button_Sound_Stop.Enabled = checkBox_PlaySound.Checked;
            if (button_SoundLocation.Enabled == false)
            {
                Sound_Helper.Stop("sound_alert");
                label_SoundLocation.Text = "";
                Settings.SoundLocation = "";
            }
            Settings.PlaySound = checkBox_PlaySound.Checked;
            Settings.Save();
        }

        private void button_SoundLocation_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "WAVE / MP3 Files|*.wav;*.mp3";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                label_SoundLocation.Text = Path.GetFileName(openFileDialog1.FileName);
                Settings.SoundLocation = openFileDialog1.FileName;
                Settings.Save();
            }
        }
        

        private void checkBox_TTS_CheckedChanged(object sender, EventArgs e)
        {
            Settings.TTS = checkBox_TTS.Checked;
            Settings.Save();
        }

        private void checkBox_DevMode_CheckedChanged(object sender, EventArgs e)
        {
            Settings.DebugLog = checkBox_DevMode.Checked;
            Settings.Save();
        }

        private void comboBox_dfaUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.dfaUpdate = comboBox_dfaUpdate.SelectedValue.ToString();
            Settings.Save();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            button_update.Enabled = false;
            Updater.CheckNewVersion(this,true);
        }

        internal void button_update_enabled()
        {
            this.Invoke(() => 
            {
                button_update.Enabled = true;
            });
        }

        private void comboBox_dataUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.dataUpdate = comboBox_dataUpdate.SelectedValue.ToString();
            Settings.Save();
        }

        private void comboBox_tts_cache_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.TTSCache = comboBox_tts_cache.SelectedValue.ToString();
            Settings.Save();
        }

        private void button_tracker_open_Click(object sender, EventArgs e)
        {
            TrackerForm.Display();
        }

        internal void tracker_disable ()
        {
            TrackerFormLoaded = false;
            checkBox_tracker_enabled.Checked = false;
        }

        private void checkBox_tracker_enabled_CheckedChanged(object sender, EventArgs e)
        {
            Settings.TrackerEnabled = checkBox_tracker_enabled.Checked;
            Settings.Save();
            if (Settings.TrackerEnabled)
            {
                if (File.Exists("node.dll") || File.Exists($@"{Environment.GetEnvironmentVariable("windir")}\node.dll"))
                {
                    TrackerForm = new TrackerForm(this);
                    TrackerFormLoaded = true;
                    TrackerForm.Show();
                }
                else
                {
                    TrackerFormLoaded = false;
                    checkBox_tracker_enabled.Enabled = false;
                    ShowNotification("notification-dll-missing","node.dll");
                    Task.Factory.StartNew(() =>
                    {
                        WebApi.Download($"http://svn.diemoe.net/ff14_diemoe/tags/DFAssist_CN/dll/node.dll", $@"{Environment.GetEnvironmentVariable("windir")}\node.dll", true, nodedll_callback);
                    });
                }
            }
            else
            {
                tracker_close();
            }
            button_tracker_open.Enabled = TrackerFormLoaded;
        }

        internal void tracker_close()
        {
            this.Invoke(() =>
            {
                TrackerFormLoaded = false;
                TrackerForm.Close();
            });
        }

        private void nodedll_callback()
        {
            Settings.NodeVersion = Global.NODE_NEED;
            Settings.Save();
            this.Invoke(() =>
            {
                TrackerForm = new TrackerForm(this);
                TrackerFormLoaded = true;
                TrackerForm.Show();
                checkBox_tracker_enabled.Enabled = true;
                button_tracker_open.Enabled = TrackerFormLoaded;
            });
        }

        private void checkBox_tracker_auto_CheckedChanged(object sender, EventArgs e)
        {
            Settings.AutoTracker = checkBox_tracker_auto.Checked;
            Settings.Save();
        }

        private void checkBox_UpdateCheckBeta_CheckedChanged(object sender, EventArgs e)
        {
            Settings.CheckBeta = checkBox_UpdateCheckBeta.Checked;
            Settings.Save();
            if (!Settings.CheckBeta)
            {
                Updater.CheckNewVersion(this, true, true);
            }
        }

        private void trackBar_tts_speed_Scroll(object sender, EventArgs e)
        {
            var ttsspeed = trackBar_tts_speed.Value.ToString();
            if (Settings.TTSSpeed == ttsspeed)
            {
                return;
            }
            Settings.TTSSpeed = ttsspeed;
            Settings.Save();
            textBox_tts_speed.Text = Settings.TTSSpeed;
            if (Settings.TTSCache != "2")
            {
                Sound_Helper.TTS_ClearCache();
            }
        }

        private void button_tts_clear_cache_Click(object sender, EventArgs e)
        {
            Sound_Helper.TTS_ClearCache();
        }

        private void button_tts_test_Click(object sender, EventArgs e)
        {
            Sound_Helper.TTS("hello world", Localization.GetText("tts-langset"));
        }

        private void checkBox_RoulleteTips_CheckedChanged(object sender, EventArgs e)
        {
            Settings.RouletteTips = checkBox_RoulleteTips.Checked;
            Settings.Save();
        }

        private void checkBox_tracker_CNmirror_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tracker_CNmirror.Checked)
            {
                Settings.TrackerMirror = "cn";
            }
            else
            {
                Settings.TrackerMirror = "0";
            }
            Settings.Save();
        }

        private void checkBox_netFilter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.NetFilter = checkBox_netFilter.Checked;
            Settings.Save();
            networkWorker.StopCapture();
            FFXIVProcess = null;
            FindFFXIVProcess();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            triStateTreeView_FATEs.Nodes.Find(toolStripTextBox1.Text, true);
        }

        private void trackBar_tts_vol_Scroll(object sender, EventArgs e)
        {
            var TTSVol = trackBar_tts_vol.Value;
            Settings.TTSVol = TTSVol;
            Settings.Save();
            textBox_tts_vol.Text = TTSVol.ToString();
        }

        private void button_Sound_Stop_Click(object sender, EventArgs e)
        {
            Sound_Helper.Stop("sound_alert");
        }
    }
}
