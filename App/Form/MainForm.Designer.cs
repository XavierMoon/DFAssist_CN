namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_ResetProcess = new System.Windows.Forms.Button();
            this.comboBox_Process = new System.Windows.Forms.ComboBox();
            this.button_SelectProcess = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_TopSetting = new System.Windows.Forms.Panel();
            this.label_Process = new App.LocalizableLabel();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_Overlay = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new App.TabControlBlack();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.tabControl_Settings = new System.Windows.Forms.TabControl();
            this.settings_basic = new System.Windows.Forms.TabPage();
            this.button_Sound_Stop = new System.Windows.Forms.Button();
            this.checkBox_RoulleteTips = new System.Windows.Forms.CheckBox();
            this.checkBox_TTS = new System.Windows.Forms.CheckBox();
            this.checkBox_StartupShow = new System.Windows.Forms.CheckBox();
            this.label_SoundLocation = new App.LocalizableLabel();
            this.checkBox_AutoOverlayHide = new System.Windows.Forms.CheckBox();
            this.button_SoundLocation = new System.Windows.Forms.Button();
            this.checkBox_FlashWindow = new System.Windows.Forms.CheckBox();
            this.checkBox_PlaySound = new System.Windows.Forms.CheckBox();
            this.button_ResetOverlayPosition = new System.Windows.Forms.Button();
            this.settings_advanced = new System.Windows.Forms.TabPage();
            this.checkBox_HeartBeatLock = new System.Windows.Forms.CheckBox();
            this.checkBox_CheatRoullete = new System.Windows.Forms.CheckBox();
            this.settings_eureka_tracker = new System.Windows.Forms.TabPage();
            this.checkBox_tracker_CNmirror = new System.Windows.Forms.CheckBox();
            this.checkBox_tracker_auto = new System.Windows.Forms.CheckBox();
            this.button_tracker_open = new System.Windows.Forms.Button();
            this.checkBox_tracker_enabled = new System.Windows.Forms.CheckBox();
            this.settings_tts = new System.Windows.Forms.TabPage();
            this.textBox_tts_vol = new System.Windows.Forms.TextBox();
            this.tts_vol = new App.LocalizableLabel();
            this.trackBar_tts_vol = new System.Windows.Forms.TrackBar();
            this.button_tts_test = new System.Windows.Forms.Button();
            this.comboBox_tts_cache = new System.Windows.Forms.ComboBox();
            this.button_tts_clear_cache = new System.Windows.Forms.Button();
            this.tts_cache = new App.LocalizableLabel();
            this.textBox_tts_speed = new System.Windows.Forms.TextBox();
            this.tts_speed = new App.LocalizableLabel();
            this.trackBar_tts_speed = new System.Windows.Forms.TrackBar();
            this.settings_update = new System.Windows.Forms.TabPage();
            this.checkBox_UpdateCheckBeta = new System.Windows.Forms.CheckBox();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_dataUpdate = new System.Windows.Forms.ComboBox();
            this.update_data_about = new App.LocalizableLabel();
            this.update_about = new App.LocalizableLabel();
            this.comboBox_dfaUpdate = new System.Windows.Forms.ComboBox();
            this.tabPage_FATE = new System.Windows.Forms.TabPage();
            this.label_FATEAbout = new App.LocalizableLabel();
            this.triStateTreeView_FATEs = new RikTheVeggie.TriStateTreeView();
            this.menuStrip_FATETab = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_UnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.presetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfireIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfireIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfNetherfireIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkyfallIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfallIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfNetherfireIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkywindIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkywindIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkyearthIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.IxionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TamamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SelectApply = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.panel_LogCover = new System.Windows.Forms.Panel();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip_LogTab = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_LogCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_devmode = new System.Windows.Forms.TabPage();
            this.groupBox_network_settings = new System.Windows.Forms.GroupBox();
            this.checkBox_netFilter = new System.Windows.Forms.CheckBox();
            this.groupBox_debug_settings = new System.Windows.Forms.GroupBox();
            this.checkBox_DevMode = new System.Windows.Forms.CheckBox();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.label_About = new App.LocalizableLabel();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.label_AboutTitle = new App.LocalizableLabel();
            this.contextMenuStrip.SuspendLayout();
            this.panel_TopSetting.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.tabControl_Settings.SuspendLayout();
            this.settings_basic.SuspendLayout();
            this.settings_advanced.SuspendLayout();
            this.settings_eureka_tracker.SuspendLayout();
            this.settings_tts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tts_vol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tts_speed)).BeginInit();
            this.settings_update.SuspendLayout();
            this.tabPage_FATE.SuspendLayout();
            this.menuStrip_FATETab.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            this.panel_LogCover.SuspendLayout();
            this.menuStrip_LogTab.SuspendLayout();
            this.tabPage_devmode.SuspendLayout();
            this.groupBox_network_settings.SuspendLayout();
            this.groupBox_debug_settings.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ResetProcess
            // 
            this.button_ResetProcess.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_ResetProcess.Location = new System.Drawing.Point(288, 0);
            this.button_ResetProcess.Name = "button_ResetProcess";
            this.button_ResetProcess.Size = new System.Drawing.Size(60, 27);
            this.button_ResetProcess.TabIndex = 0;
            this.button_ResetProcess.Text = "재설정";
            this.button_ResetProcess.UseVisualStyleBackColor = true;
            this.button_ResetProcess.Click += new System.EventHandler(this.button_ResetProcess_Click);
            // 
            // comboBox_Process
            // 
            this.comboBox_Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Process.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox_Process.FormattingEnabled = true;
            this.comboBox_Process.Location = new System.Drawing.Point(107, 2);
            this.comboBox_Process.Name = "comboBox_Process";
            this.comboBox_Process.Size = new System.Drawing.Size(120, 25);
            this.comboBox_Process.Sorted = true;
            this.comboBox_Process.TabIndex = 0;
            // 
            // button_SelectProcess
            // 
            this.button_SelectProcess.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_SelectProcess.Location = new System.Drawing.Point(228, 0);
            this.button_SelectProcess.Name = "button_SelectProcess";
            this.button_SelectProcess.Size = new System.Drawing.Size(60, 27);
            this.button_SelectProcess.TabIndex = 0;
            this.button_SelectProcess.Text = "수동설정";
            this.button_SelectProcess.UseVisualStyleBackColor = true;
            this.button_SelectProcess.Click += new System.EventHandler(this.button_SelectProcess_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = global::App.Properties.Resources.icon;
            this.notifyIcon.Text = "임무/돌발 찾기 도우미";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Close});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Open.Text = "열기";
            this.toolStripMenuItem_Open.Click += new System.EventHandler(this.toolStripMenuItem_Open_Click);
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Close.Text = "종료";
            this.toolStripMenuItem_Close.Click += new System.EventHandler(this.toolStripMenuItem_Close_Click);
            // 
            // panel_TopSetting
            // 
            this.panel_TopSetting.BackColor = System.Drawing.Color.Silver;
            this.panel_TopSetting.Controls.Add(this.label_Process);
            this.panel_TopSetting.Controls.Add(this.comboBox_Language);
            this.panel_TopSetting.Controls.Add(this.comboBox_Process);
            this.panel_TopSetting.Controls.Add(this.button_SelectProcess);
            this.panel_TopSetting.Controls.Add(this.button_ResetProcess);
            this.panel_TopSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopSetting.Location = new System.Drawing.Point(0, 0);
            this.panel_TopSetting.Name = "panel_TopSetting";
            this.panel_TopSetting.Padding = new System.Windows.Forms.Padding(5);
            this.panel_TopSetting.Size = new System.Drawing.Size(554, 27);
            this.panel_TopSetting.TabIndex = 1;
            // 
            // label_Process
            // 
            this.label_Process.AutoSize = true;
            this.label_Process.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Process.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Process.ForeColor = System.Drawing.Color.Gray;
            this.label_Process.Location = new System.Drawing.Point(5, 5);
            this.label_Process.Name = "label_Process";
            this.label_Process.Size = new System.Drawing.Size(101, 19);
            this.label_Process.TabIndex = 0;
            this.label_Process.Text = "FFXIV 프로세스";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Language.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Language.DisplayMember = "Code";
            this.comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Language.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Location = new System.Drawing.Point(461, 2);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(91, 25);
            this.comboBox_Language.TabIndex = 4;
            this.comboBox_Language.ValueMember = "Code";
            // 
            // checkBox_Overlay
            // 
            this.checkBox_Overlay.AutoSize = true;
            this.checkBox_Overlay.Checked = true;
            this.checkBox_Overlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Overlay.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_Overlay.Location = new System.Drawing.Point(6, 6);
            this.checkBox_Overlay.Name = "checkBox_Overlay";
            this.checkBox_Overlay.Size = new System.Drawing.Size(103, 21);
            this.checkBox_Overlay.TabIndex = 0;
            this.checkBox_Overlay.Text = "오버레이 사용";
            this.toolTip.SetToolTip(this.checkBox_Overlay, "오버레이 UI의 좌측 막대를 이용해 드래그 할 수 있습니다.");
            this.checkBox_Overlay.UseVisualStyleBackColor = true;
            this.checkBox_Overlay.CheckedChanged += new System.EventHandler(this.checkBox_Overlay_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPage_Settings);
            this.tabControl.Controls.Add(this.tabPage_FATE);
            this.tabControl.Controls.Add(this.tabPage_Log);
            this.tabControl.Controls.Add(this.tabPage_devmode);
            this.tabControl.Controls.Add(this.tabPage_Info);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(30, 110);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(554, 270);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Settings.Controls.Add(this.tabControl_Settings);
            this.tabPage_Settings.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(436, 262);
            this.tabPage_Settings.TabIndex = 1;
            this.tabPage_Settings.Text = "설정";
            // 
            // tabControl_Settings
            // 
            this.tabControl_Settings.Controls.Add(this.settings_basic);
            this.tabControl_Settings.Controls.Add(this.settings_advanced);
            this.tabControl_Settings.Controls.Add(this.settings_eureka_tracker);
            this.tabControl_Settings.Controls.Add(this.settings_tts);
            this.tabControl_Settings.Controls.Add(this.settings_update);
            this.tabControl_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Settings.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Settings.Multiline = true;
            this.tabControl_Settings.Name = "tabControl_Settings";
            this.tabControl_Settings.SelectedIndex = 0;
            this.tabControl_Settings.Size = new System.Drawing.Size(436, 262);
            this.tabControl_Settings.TabIndex = 5;
            // 
            // settings_basic
            // 
            this.settings_basic.BackColor = System.Drawing.SystemColors.Control;
            this.settings_basic.Controls.Add(this.button_Sound_Stop);
            this.settings_basic.Controls.Add(this.checkBox_RoulleteTips);
            this.settings_basic.Controls.Add(this.checkBox_Overlay);
            this.settings_basic.Controls.Add(this.checkBox_TTS);
            this.settings_basic.Controls.Add(this.checkBox_StartupShow);
            this.settings_basic.Controls.Add(this.label_SoundLocation);
            this.settings_basic.Controls.Add(this.checkBox_AutoOverlayHide);
            this.settings_basic.Controls.Add(this.button_SoundLocation);
            this.settings_basic.Controls.Add(this.checkBox_FlashWindow);
            this.settings_basic.Controls.Add(this.checkBox_PlaySound);
            this.settings_basic.Controls.Add(this.button_ResetOverlayPosition);
            this.settings_basic.Location = new System.Drawing.Point(4, 28);
            this.settings_basic.Name = "settings_basic";
            this.settings_basic.Padding = new System.Windows.Forms.Padding(3);
            this.settings_basic.Size = new System.Drawing.Size(428, 230);
            this.settings_basic.TabIndex = 0;
            this.settings_basic.Text = "基础设置";
            // 
            // button_Sound_Stop
            // 
            this.button_Sound_Stop.AutoSize = true;
            this.button_Sound_Stop.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_Sound_Stop.Location = new System.Drawing.Point(309, 193);
            this.button_Sound_Stop.Name = "button_Sound_Stop";
            this.button_Sound_Stop.Size = new System.Drawing.Size(113, 26);
            this.button_Sound_Stop.TabIndex = 8;
            this.button_Sound_Stop.Text = "停止播放";
            this.button_Sound_Stop.UseVisualStyleBackColor = true;
            this.button_Sound_Stop.Click += new System.EventHandler(this.button_Sound_Stop_Click);
            // 
            // checkBox_RoulleteTips
            // 
            this.checkBox_RoulleteTips.AutoSize = true;
            this.checkBox_RoulleteTips.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_RoulleteTips.Location = new System.Drawing.Point(6, 112);
            this.checkBox_RoulleteTips.Name = "checkBox_RoulleteTips";
            this.checkBox_RoulleteTips.Size = new System.Drawing.Size(351, 21);
            this.checkBox_RoulleteTips.TabIndex = 7;
            this.checkBox_RoulleteTips.Text = "通过随机任务匹配进入副本时显示简易副本攻略（如果支持）";
            this.checkBox_RoulleteTips.UseVisualStyleBackColor = true;
            this.checkBox_RoulleteTips.CheckedChanged += new System.EventHandler(this.checkBox_RoulleteTips_CheckedChanged);
            // 
            // checkBox_TTS
            // 
            this.checkBox_TTS.AutoSize = true;
            this.checkBox_TTS.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_TTS.Location = new System.Drawing.Point(6, 139);
            this.checkBox_TTS.Name = "checkBox_TTS";
            this.checkBox_TTS.Size = new System.Drawing.Size(91, 21);
            this.checkBox_TTS.TabIndex = 6;
            this.checkBox_TTS.Text = "텍스트 음성";
            this.checkBox_TTS.UseVisualStyleBackColor = true;
            this.checkBox_TTS.CheckedChanged += new System.EventHandler(this.checkBox_TTS_CheckedChanged);
            // 
            // checkBox_StartupShow
            // 
            this.checkBox_StartupShow.AutoSize = true;
            this.checkBox_StartupShow.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_StartupShow.Location = new System.Drawing.Point(6, 58);
            this.checkBox_StartupShow.Name = "checkBox_StartupShow";
            this.checkBox_StartupShow.Size = new System.Drawing.Size(187, 21);
            this.checkBox_StartupShow.TabIndex = 0;
            this.checkBox_StartupShow.Text = "프로그램 시작시 이 창 보이기";
            this.checkBox_StartupShow.UseVisualStyleBackColor = true;
            this.checkBox_StartupShow.CheckedChanged += new System.EventHandler(this.checkBox_StartupShow_CheckedChanged);
            // 
            // label_SoundLocation
            // 
            this.label_SoundLocation.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label_SoundLocation.Location = new System.Drawing.Point(6, 190);
            this.label_SoundLocation.Name = "label_SoundLocation";
            this.label_SoundLocation.Size = new System.Drawing.Size(225, 13);
            this.label_SoundLocation.TabIndex = 1;
            // 
            // checkBox_AutoOverlayHide
            // 
            this.checkBox_AutoOverlayHide.AutoSize = true;
            this.checkBox_AutoOverlayHide.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_AutoOverlayHide.Location = new System.Drawing.Point(6, 31);
            this.checkBox_AutoOverlayHide.Name = "checkBox_AutoOverlayHide";
            this.checkBox_AutoOverlayHide.Size = new System.Drawing.Size(223, 21);
            this.checkBox_AutoOverlayHide.TabIndex = 1;
            this.checkBox_AutoOverlayHide.Text = "임무 입장시 자동으로 오버레이 숨김";
            this.checkBox_AutoOverlayHide.UseVisualStyleBackColor = true;
            this.checkBox_AutoOverlayHide.CheckedChanged += new System.EventHandler(this.checkBox_AutoOverlayHide_CheckedChanged);
            // 
            // button_SoundLocation
            // 
            this.button_SoundLocation.AutoSize = true;
            this.button_SoundLocation.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_SoundLocation.Location = new System.Drawing.Point(309, 161);
            this.button_SoundLocation.Name = "button_SoundLocation";
            this.button_SoundLocation.Size = new System.Drawing.Size(113, 26);
            this.button_SoundLocation.TabIndex = 5;
            this.button_SoundLocation.Text = "사운드 선택";
            this.button_SoundLocation.UseVisualStyleBackColor = true;
            this.button_SoundLocation.Click += new System.EventHandler(this.button_SoundLocation_Click);
            // 
            // checkBox_FlashWindow
            // 
            this.checkBox_FlashWindow.AutoSize = true;
            this.checkBox_FlashWindow.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_FlashWindow.Location = new System.Drawing.Point(6, 85);
            this.checkBox_FlashWindow.Name = "checkBox_FlashWindow";
            this.checkBox_FlashWindow.Size = new System.Drawing.Size(370, 21);
            this.checkBox_FlashWindow.TabIndex = 2;
            this.checkBox_FlashWindow.Text = "매칭/돌발 발생시 파이널판타지14 작업 표시줄 아이콘 깜빡이기";
            this.checkBox_FlashWindow.UseVisualStyleBackColor = true;
            this.checkBox_FlashWindow.CheckedChanged += new System.EventHandler(this.checkBox_FlashWindow_CheckedChanged);
            // 
            // checkBox_PlaySound
            // 
            this.checkBox_PlaySound.AutoSize = true;
            this.checkBox_PlaySound.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_PlaySound.Location = new System.Drawing.Point(6, 166);
            this.checkBox_PlaySound.Name = "checkBox_PlaySound";
            this.checkBox_PlaySound.Size = new System.Drawing.Size(91, 21);
            this.checkBox_PlaySound.TabIndex = 4;
            this.checkBox_PlaySound.Text = "사운드 재생";
            this.checkBox_PlaySound.UseVisualStyleBackColor = true;
            this.checkBox_PlaySound.CheckedChanged += new System.EventHandler(this.checkBox_PlaySound_CheckedChanged);
            // 
            // button_ResetOverlayPosition
            // 
            this.button_ResetOverlayPosition.AutoSize = true;
            this.button_ResetOverlayPosition.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_ResetOverlayPosition.Location = new System.Drawing.Point(309, 3);
            this.button_ResetOverlayPosition.Name = "button_ResetOverlayPosition";
            this.button_ResetOverlayPosition.Size = new System.Drawing.Size(114, 26);
            this.button_ResetOverlayPosition.TabIndex = 0;
            this.button_ResetOverlayPosition.Text = "위치 초기화";
            this.button_ResetOverlayPosition.UseVisualStyleBackColor = true;
            this.button_ResetOverlayPosition.Click += new System.EventHandler(this.button_ResetOverlayPosition_Click);
            // 
            // settings_advanced
            // 
            this.settings_advanced.BackColor = System.Drawing.SystemColors.Control;
            this.settings_advanced.Controls.Add(this.checkBox_HeartBeatLock);
            this.settings_advanced.Controls.Add(this.checkBox_CheatRoullete);
            this.settings_advanced.Location = new System.Drawing.Point(4, 28);
            this.settings_advanced.Name = "settings_advanced";
            this.settings_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.settings_advanced.Size = new System.Drawing.Size(428, 230);
            this.settings_advanced.TabIndex = 4;
            this.settings_advanced.Text = "高级功能";
            // 
            // checkBox_HeartBeatLock
            // 
            this.checkBox_HeartBeatLock.AutoSize = true;
            this.checkBox_HeartBeatLock.Enabled = false;
            this.checkBox_HeartBeatLock.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_HeartBeatLock.Location = new System.Drawing.Point(6, 33);
            this.checkBox_HeartBeatLock.Name = "checkBox_HeartBeatLock";
            this.checkBox_HeartBeatLock.Size = new System.Drawing.Size(389, 21);
            this.checkBox_HeartBeatLock.TabIndex = 8;
            this.checkBox_HeartBeatLock.Text = "当玩家在30分钟内没有进行任何操作时，将不会自动被系统登出游戏";
            this.checkBox_HeartBeatLock.UseVisualStyleBackColor = true;
            // 
            // checkBox_CheatRoullete
            // 
            this.checkBox_CheatRoullete.AutoSize = true;
            this.checkBox_CheatRoullete.Enabled = false;
            this.checkBox_CheatRoullete.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_CheatRoullete.Location = new System.Drawing.Point(6, 6);
            this.checkBox_CheatRoullete.Name = "checkBox_CheatRoullete";
            this.checkBox_CheatRoullete.Size = new System.Drawing.Size(303, 21);
            this.checkBox_CheatRoullete.TabIndex = 4;
            this.checkBox_CheatRoullete.Text = "무작위 임무일 경우에도 실제 매칭된 임무 보여주기";
            this.checkBox_CheatRoullete.UseVisualStyleBackColor = true;
            // 
            // settings_eureka_tracker
            // 
            this.settings_eureka_tracker.BackColor = System.Drawing.SystemColors.Control;
            this.settings_eureka_tracker.Controls.Add(this.checkBox_tracker_CNmirror);
            this.settings_eureka_tracker.Controls.Add(this.checkBox_tracker_auto);
            this.settings_eureka_tracker.Controls.Add(this.button_tracker_open);
            this.settings_eureka_tracker.Controls.Add(this.checkBox_tracker_enabled);
            this.settings_eureka_tracker.Location = new System.Drawing.Point(4, 28);
            this.settings_eureka_tracker.Name = "settings_eureka_tracker";
            this.settings_eureka_tracker.Padding = new System.Windows.Forms.Padding(3);
            this.settings_eureka_tracker.Size = new System.Drawing.Size(428, 230);
            this.settings_eureka_tracker.TabIndex = 3;
            this.settings_eureka_tracker.Text = "优雷卡追踪器";
            // 
            // checkBox_tracker_CNmirror
            // 
            this.checkBox_tracker_CNmirror.AutoSize = true;
            this.checkBox_tracker_CNmirror.Location = new System.Drawing.Point(22, 35);
            this.checkBox_tracker_CNmirror.Name = "checkBox_tracker_CNmirror";
            this.checkBox_tracker_CNmirror.Size = new System.Drawing.Size(158, 23);
            this.checkBox_tracker_CNmirror.TabIndex = 3;
            this.checkBox_tracker_CNmirror.Text = "使用国内镜像加速访问";
            this.checkBox_tracker_CNmirror.UseVisualStyleBackColor = true;
            this.checkBox_tracker_CNmirror.CheckedChanged += new System.EventHandler(this.checkBox_tracker_CNmirror_CheckedChanged);
            // 
            // checkBox_tracker_auto
            // 
            this.checkBox_tracker_auto.AutoSize = true;
            this.checkBox_tracker_auto.Location = new System.Drawing.Point(6, 64);
            this.checkBox_tracker_auto.Name = "checkBox_tracker_auto";
            this.checkBox_tracker_auto.Size = new System.Drawing.Size(249, 23);
            this.checkBox_tracker_auto.TabIndex = 2;
            this.checkBox_tracker_auto.Text = "进入禁地优雷卡区域时自动记录追踪器";
            this.checkBox_tracker_auto.UseVisualStyleBackColor = true;
            this.checkBox_tracker_auto.CheckedChanged += new System.EventHandler(this.checkBox_tracker_auto_CheckedChanged);
            // 
            // button_tracker_open
            // 
            this.button_tracker_open.AutoSize = true;
            this.button_tracker_open.Enabled = false;
            this.button_tracker_open.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_tracker_open.Location = new System.Drawing.Point(319, 3);
            this.button_tracker_open.Name = "button_tracker_open";
            this.button_tracker_open.Size = new System.Drawing.Size(103, 26);
            this.button_tracker_open.TabIndex = 1;
            this.button_tracker_open.Text = "打开追踪器";
            this.button_tracker_open.UseVisualStyleBackColor = true;
            this.button_tracker_open.Click += new System.EventHandler(this.button_tracker_open_Click);
            // 
            // checkBox_tracker_enabled
            // 
            this.checkBox_tracker_enabled.AutoSize = true;
            this.checkBox_tracker_enabled.Location = new System.Drawing.Point(6, 6);
            this.checkBox_tracker_enabled.Name = "checkBox_tracker_enabled";
            this.checkBox_tracker_enabled.Size = new System.Drawing.Size(132, 23);
            this.checkBox_tracker_enabled.TabIndex = 0;
            this.checkBox_tracker_enabled.Text = "启用优雷卡追踪器";
            this.checkBox_tracker_enabled.UseVisualStyleBackColor = true;
            this.checkBox_tracker_enabled.CheckedChanged += new System.EventHandler(this.checkBox_tracker_enabled_CheckedChanged);
            // 
            // settings_tts
            // 
            this.settings_tts.BackColor = System.Drawing.SystemColors.Control;
            this.settings_tts.Controls.Add(this.textBox_tts_vol);
            this.settings_tts.Controls.Add(this.tts_vol);
            this.settings_tts.Controls.Add(this.trackBar_tts_vol);
            this.settings_tts.Controls.Add(this.button_tts_test);
            this.settings_tts.Controls.Add(this.comboBox_tts_cache);
            this.settings_tts.Controls.Add(this.button_tts_clear_cache);
            this.settings_tts.Controls.Add(this.tts_cache);
            this.settings_tts.Controls.Add(this.textBox_tts_speed);
            this.settings_tts.Controls.Add(this.tts_speed);
            this.settings_tts.Controls.Add(this.trackBar_tts_speed);
            this.settings_tts.Location = new System.Drawing.Point(4, 28);
            this.settings_tts.Name = "settings_tts";
            this.settings_tts.Padding = new System.Windows.Forms.Padding(3);
            this.settings_tts.Size = new System.Drawing.Size(428, 230);
            this.settings_tts.TabIndex = 1;
            this.settings_tts.Text = "TTS设置";
            // 
            // textBox_tts_vol
            // 
            this.textBox_tts_vol.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_tts_vol.Enabled = false;
            this.textBox_tts_vol.Location = new System.Drawing.Point(10, 76);
            this.textBox_tts_vol.Name = "textBox_tts_vol";
            this.textBox_tts_vol.Size = new System.Drawing.Size(66, 25);
            this.textBox_tts_vol.TabIndex = 14;
            this.textBox_tts_vol.Text = "100";
            this.textBox_tts_vol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tts_vol
            // 
            this.tts_vol.AutoSize = true;
            this.tts_vol.Location = new System.Drawing.Point(6, 54);
            this.tts_vol.Name = "tts_vol";
            this.tts_vol.Size = new System.Drawing.Size(61, 19);
            this.tts_vol.TabIndex = 13;
            this.tts_vol.Text = "朗读音量";
            // 
            // trackBar_tts_vol
            // 
            this.trackBar_tts_vol.Location = new System.Drawing.Point(82, 57);
            this.trackBar_tts_vol.Maximum = 100;
            this.trackBar_tts_vol.Name = "trackBar_tts_vol";
            this.trackBar_tts_vol.Size = new System.Drawing.Size(340, 45);
            this.trackBar_tts_vol.TabIndex = 12;
            this.trackBar_tts_vol.TickFrequency = 25;
            this.trackBar_tts_vol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_tts_vol.Value = 100;
            this.trackBar_tts_vol.Scroll += new System.EventHandler(this.trackBar_tts_vol_Scroll);
            // 
            // button_tts_test
            // 
            this.button_tts_test.AutoSize = true;
            this.button_tts_test.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_tts_test.Location = new System.Drawing.Point(3, 169);
            this.button_tts_test.Name = "button_tts_test";
            this.button_tts_test.Size = new System.Drawing.Size(422, 29);
            this.button_tts_test.TabIndex = 11;
            this.button_tts_test.Text = "朗读测试";
            this.button_tts_test.UseVisualStyleBackColor = true;
            this.button_tts_test.Click += new System.EventHandler(this.button_tts_test_Click);
            // 
            // comboBox_tts_cache
            // 
            this.comboBox_tts_cache.DisplayMember = "Code";
            this.comboBox_tts_cache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tts_cache.FormattingEnabled = true;
            this.comboBox_tts_cache.Location = new System.Drawing.Point(38, 136);
            this.comboBox_tts_cache.Name = "comboBox_tts_cache";
            this.comboBox_tts_cache.Size = new System.Drawing.Size(384, 27);
            this.comboBox_tts_cache.TabIndex = 10;
            this.comboBox_tts_cache.ValueMember = "Code";
            // 
            // button_tts_clear_cache
            // 
            this.button_tts_clear_cache.AutoSize = true;
            this.button_tts_clear_cache.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_tts_clear_cache.Location = new System.Drawing.Point(3, 198);
            this.button_tts_clear_cache.Name = "button_tts_clear_cache";
            this.button_tts_clear_cache.Size = new System.Drawing.Size(422, 29);
            this.button_tts_clear_cache.TabIndex = 9;
            this.button_tts_clear_cache.Text = "清空缓存";
            this.button_tts_clear_cache.UseVisualStyleBackColor = true;
            this.button_tts_clear_cache.Click += new System.EventHandler(this.button_tts_clear_cache_Click);
            // 
            // tts_cache
            // 
            this.tts_cache.AutoSize = true;
            this.tts_cache.Location = new System.Drawing.Point(6, 114);
            this.tts_cache.Name = "tts_cache";
            this.tts_cache.Size = new System.Drawing.Size(61, 19);
            this.tts_cache.TabIndex = 5;
            this.tts_cache.Text = "缓存策略";
            // 
            // textBox_tts_speed
            // 
            this.textBox_tts_speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_tts_speed.Enabled = false;
            this.textBox_tts_speed.Location = new System.Drawing.Point(10, 25);
            this.textBox_tts_speed.Name = "textBox_tts_speed";
            this.textBox_tts_speed.Size = new System.Drawing.Size(66, 25);
            this.textBox_tts_speed.TabIndex = 4;
            this.textBox_tts_speed.Text = "4";
            this.textBox_tts_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tts_speed
            // 
            this.tts_speed.AutoSize = true;
            this.tts_speed.Location = new System.Drawing.Point(6, 3);
            this.tts_speed.Name = "tts_speed";
            this.tts_speed.Size = new System.Drawing.Size(61, 19);
            this.tts_speed.TabIndex = 3;
            this.tts_speed.Text = "朗读速度";
            // 
            // trackBar_tts_speed
            // 
            this.trackBar_tts_speed.LargeChange = 1;
            this.trackBar_tts_speed.Location = new System.Drawing.Point(82, 6);
            this.trackBar_tts_speed.Maximum = 7;
            this.trackBar_tts_speed.Minimum = 1;
            this.trackBar_tts_speed.Name = "trackBar_tts_speed";
            this.trackBar_tts_speed.Size = new System.Drawing.Size(340, 45);
            this.trackBar_tts_speed.TabIndex = 0;
            this.trackBar_tts_speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_tts_speed.Value = 4;
            this.trackBar_tts_speed.Scroll += new System.EventHandler(this.trackBar_tts_speed_Scroll);
            // 
            // settings_update
            // 
            this.settings_update.BackColor = System.Drawing.SystemColors.Control;
            this.settings_update.Controls.Add(this.checkBox_UpdateCheckBeta);
            this.settings_update.Controls.Add(this.button_update);
            this.settings_update.Controls.Add(this.comboBox_dataUpdate);
            this.settings_update.Controls.Add(this.update_data_about);
            this.settings_update.Controls.Add(this.update_about);
            this.settings_update.Controls.Add(this.comboBox_dfaUpdate);
            this.settings_update.Location = new System.Drawing.Point(4, 28);
            this.settings_update.Name = "settings_update";
            this.settings_update.Padding = new System.Windows.Forms.Padding(3);
            this.settings_update.Size = new System.Drawing.Size(428, 230);
            this.settings_update.TabIndex = 2;
            this.settings_update.Text = "更新选项";
            // 
            // checkBox_UpdateCheckBeta
            // 
            this.checkBox_UpdateCheckBeta.AutoSize = true;
            this.checkBox_UpdateCheckBeta.Location = new System.Drawing.Point(10, 110);
            this.checkBox_UpdateCheckBeta.Name = "checkBox_UpdateCheckBeta";
            this.checkBox_UpdateCheckBeta.Size = new System.Drawing.Size(133, 23);
            this.checkBox_UpdateCheckBeta.TabIndex = 6;
            this.checkBox_UpdateCheckBeta.Text = "接受Beta版本推送";
            this.checkBox_UpdateCheckBeta.UseVisualStyleBackColor = true;
            this.checkBox_UpdateCheckBeta.CheckedChanged += new System.EventHandler(this.checkBox_UpdateCheckBeta_CheckedChanged);
            // 
            // button_update
            // 
            this.button_update.AutoSize = true;
            this.button_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_update.Location = new System.Drawing.Point(3, 198);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(422, 29);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "手动更新";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_dataUpdate
            // 
            this.comboBox_dataUpdate.DisplayMember = "Code";
            this.comboBox_dataUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataUpdate.FormattingEnabled = true;
            this.comboBox_dataUpdate.Location = new System.Drawing.Point(38, 77);
            this.comboBox_dataUpdate.Name = "comboBox_dataUpdate";
            this.comboBox_dataUpdate.Size = new System.Drawing.Size(384, 27);
            this.comboBox_dataUpdate.TabIndex = 4;
            this.comboBox_dataUpdate.ValueMember = "Code";
            // 
            // update_data_about
            // 
            this.update_data_about.AutoSize = true;
            this.update_data_about.Location = new System.Drawing.Point(6, 55);
            this.update_data_about.Name = "update_data_about";
            this.update_data_about.Size = new System.Drawing.Size(170, 19);
            this.update_data_about.TabIndex = 3;
            this.update_data_about.Text = "当 任务/FATE数据 有更新时";
            // 
            // update_about
            // 
            this.update_about.AutoSize = true;
            this.update_about.Location = new System.Drawing.Point(6, 3);
            this.update_about.Name = "update_about";
            this.update_about.Size = new System.Drawing.Size(139, 19);
            this.update_about.TabIndex = 2;
            this.update_about.Text = "当DFA主程序有更新时";
            // 
            // comboBox_dfaUpdate
            // 
            this.comboBox_dfaUpdate.DisplayMember = "Code";
            this.comboBox_dfaUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dfaUpdate.FormattingEnabled = true;
            this.comboBox_dfaUpdate.Location = new System.Drawing.Point(38, 25);
            this.comboBox_dfaUpdate.Name = "comboBox_dfaUpdate";
            this.comboBox_dfaUpdate.Size = new System.Drawing.Size(384, 27);
            this.comboBox_dfaUpdate.TabIndex = 1;
            this.comboBox_dfaUpdate.ValueMember = "Code";
            // 
            // tabPage_FATE
            // 
            this.tabPage_FATE.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_FATE.Controls.Add(this.label_FATEAbout);
            this.tabPage_FATE.Controls.Add(this.triStateTreeView_FATEs);
            this.tabPage_FATE.Controls.Add(this.menuStrip_FATETab);
            this.tabPage_FATE.Location = new System.Drawing.Point(114, 4);
            this.tabPage_FATE.Name = "tabPage_FATE";
            this.tabPage_FATE.Size = new System.Drawing.Size(436, 262);
            this.tabPage_FATE.TabIndex = 0;
            this.tabPage_FATE.Text = "돌발";
            // 
            // label_FATEAbout
            // 
            this.label_FATEAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_FATEAbout.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label_FATEAbout.Location = new System.Drawing.Point(0, 230);
            this.label_FATEAbout.Name = "label_FATEAbout";
            this.label_FATEAbout.Size = new System.Drawing.Size(436, 32);
            this.label_FATEAbout.TabIndex = 2;
            this.label_FATEAbout.Text = "알림을 받고자 하는 돌발을 선택하신 뒤 상단 적용하기 버튼을 눌러주세요.\r\n돌발 알림은 캐릭터가 해당 지역에 있을 때에만 동작합니다.";
            // 
            // triStateTreeView_FATEs
            // 
            this.triStateTreeView_FATEs.BackColor = System.Drawing.SystemColors.Control;
            this.triStateTreeView_FATEs.Dock = System.Windows.Forms.DockStyle.Top;
            this.triStateTreeView_FATEs.FullRowSelect = true;
            this.triStateTreeView_FATEs.HotTracking = true;
            this.triStateTreeView_FATEs.Location = new System.Drawing.Point(0, 27);
            this.triStateTreeView_FATEs.Name = "triStateTreeView_FATEs";
            this.triStateTreeView_FATEs.Size = new System.Drawing.Size(436, 203);
            this.triStateTreeView_FATEs.TabIndex = 0;
            this.triStateTreeView_FATEs.TriStateStyleProperty = RikTheVeggie.TriStateTreeView.TriStateStyles.Installer;
            // 
            // menuStrip_FATETab
            // 
            this.menuStrip_FATETab.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_FATETab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SelectAll,
            this.toolStripMenuItem_UnSelectAll,
            this.presetToolStripMenuItem,
            this.toolStripMenuItem_SelectApply,
            this.toolStripTextBox1});
            this.menuStrip_FATETab.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_FATETab.Name = "menuStrip_FATETab";
            this.menuStrip_FATETab.Size = new System.Drawing.Size(436, 27);
            this.menuStrip_FATETab.TabIndex = 0;
            this.menuStrip_FATETab.Text = "menuStrip1";
            // 
            // toolStripMenuItem_SelectAll
            // 
            this.toolStripMenuItem_SelectAll.Name = "toolStripMenuItem_SelectAll";
            this.toolStripMenuItem_SelectAll.Size = new System.Drawing.Size(72, 23);
            this.toolStripMenuItem_SelectAll.Text = "모두 선택";
            this.toolStripMenuItem_SelectAll.Click += new System.EventHandler(this.toolStripMenuItem_SelectAll_Click);
            // 
            // toolStripMenuItem_UnSelectAll
            // 
            this.toolStripMenuItem_UnSelectAll.Name = "toolStripMenuItem_UnSelectAll";
            this.toolStripMenuItem_UnSelectAll.Size = new System.Drawing.Size(72, 23);
            this.toolStripMenuItem_UnSelectAll.Text = "모두 해제";
            this.toolStripMenuItem_UnSelectAll.Click += new System.EventHandler(this.toolStripMenuItem_UnSelectAll_Click);
            // 
            // presetToolStripMenuItem
            // 
            this.presetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookOfSkyfireIToolStripMenuItem,
            this.bookOfSkyfireIIToolStripMenuItem,
            this.bookOfNetherfireIToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bookOfSkyfallIToolStripMenuItem,
            this.bookOfSkyfallIIToolStripMenuItem,
            this.bookOfNetherfireIToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.bookOfSkywindIToolStripMenuItem,
            this.bookOfSkywindIIToolStripMenuItem,
            this.toolStripMenuItem3,
            this.bookOfSkyearthIToolStripMenuItem,
            this.toolStripSeparator1,
            this.IxionToolStripMenuItem,
            this.TamamoToolStripMenuItem});
            this.presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            this.presetToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.presetToolStripMenuItem.Text = "프리셋";
            // 
            // bookOfSkyfireIToolStripMenuItem
            // 
            this.bookOfSkyfireIToolStripMenuItem.Name = "bookOfSkyfireIToolStripMenuItem";
            this.bookOfSkyfireIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfireIToolStripMenuItem.Text = "불의 서 1권";
            this.bookOfSkyfireIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfireIToolStripMenuItem_Click);
            // 
            // bookOfSkyfireIIToolStripMenuItem
            // 
            this.bookOfSkyfireIIToolStripMenuItem.Name = "bookOfSkyfireIIToolStripMenuItem";
            this.bookOfSkyfireIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfireIIToolStripMenuItem.Text = "불의 서 2권";
            this.bookOfSkyfireIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfireIIToolStripMenuItem_Click);
            // 
            // bookOfNetherfireIToolStripMenuItem
            // 
            this.bookOfNetherfireIToolStripMenuItem.Name = "bookOfNetherfireIToolStripMenuItem";
            this.bookOfNetherfireIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfNetherfireIToolStripMenuItem.Text = "불의 서 3권";
            this.bookOfNetherfireIToolStripMenuItem.Click += new System.EventHandler(this.bookOfNetherfireIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkyfallIToolStripMenuItem
            // 
            this.bookOfSkyfallIToolStripMenuItem.Name = "bookOfSkyfallIToolStripMenuItem";
            this.bookOfSkyfallIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfallIToolStripMenuItem.Text = "물의 서 1권";
            this.bookOfSkyfallIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfallIToolStripMenuItem_Click);
            // 
            // bookOfSkyfallIIToolStripMenuItem
            // 
            this.bookOfSkyfallIIToolStripMenuItem.Name = "bookOfSkyfallIIToolStripMenuItem";
            this.bookOfSkyfallIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfallIIToolStripMenuItem.Text = "물의 서 2권";
            this.bookOfSkyfallIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfallIIToolStripMenuItem_Click);
            // 
            // bookOfNetherfireIToolStripMenuItem1
            // 
            this.bookOfNetherfireIToolStripMenuItem1.Name = "bookOfNetherfireIToolStripMenuItem1";
            this.bookOfNetherfireIToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.bookOfNetherfireIToolStripMenuItem1.Text = "물의 서 3권";
            this.bookOfNetherfireIToolStripMenuItem1.Click += new System.EventHandler(this.bookOfNetherfireIToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkywindIToolStripMenuItem
            // 
            this.bookOfSkywindIToolStripMenuItem.Name = "bookOfSkywindIToolStripMenuItem";
            this.bookOfSkywindIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkywindIToolStripMenuItem.Text = "바람의 서 1권";
            this.bookOfSkywindIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkywindIToolStripMenuItem_Click);
            // 
            // bookOfSkywindIIToolStripMenuItem
            // 
            this.bookOfSkywindIIToolStripMenuItem.Name = "bookOfSkywindIIToolStripMenuItem";
            this.bookOfSkywindIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkywindIIToolStripMenuItem.Text = "바람의 서 2권";
            this.bookOfSkywindIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkywindIIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkyearthIToolStripMenuItem
            // 
            this.bookOfSkyearthIToolStripMenuItem.Name = "bookOfSkyearthIToolStripMenuItem";
            this.bookOfSkyearthIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyearthIToolStripMenuItem.Text = "땅의 서 1권";
            this.bookOfSkyearthIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyearthIToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // IxionToolStripMenuItem
            // 
            this.IxionToolStripMenuItem.Name = "IxionToolStripMenuItem";
            this.IxionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.IxionToolStripMenuItem.Text = "익시온";
            this.IxionToolStripMenuItem.Click += new System.EventHandler(this.IxionToolStripMenuItem_Click);
            // 
            // TamamoToolStripMenuItem
            // 
            this.TamamoToolStripMenuItem.Name = "TamamoToolStripMenuItem";
            this.TamamoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.TamamoToolStripMenuItem.Text = "타마모";
            this.TamamoToolStripMenuItem.Click += new System.EventHandler(this.TamamoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_SelectApply
            // 
            this.toolStripMenuItem_SelectApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem_SelectApply.Name = "toolStripMenuItem_SelectApply";
            this.toolStripMenuItem_SelectApply.Size = new System.Drawing.Size(67, 23);
            this.toolStripMenuItem_SelectApply.Text = "적용하기";
            this.toolStripMenuItem_SelectApply.Click += new System.EventHandler(this.toolStripMenuItem_SelectApply_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Log.Controls.Add(this.panel_LogCover);
            this.tabPage_Log.Controls.Add(this.menuStrip_LogTab);
            this.tabPage_Log.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Size = new System.Drawing.Size(436, 262);
            this.tabPage_Log.TabIndex = 2;
            this.tabPage_Log.Text = "로그";
            // 
            // panel_LogCover
            // 
            this.panel_LogCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LogCover.Controls.Add(this.richTextBox_Log);
            this.panel_LogCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LogCover.Location = new System.Drawing.Point(0, 25);
            this.panel_LogCover.Name = "panel_LogCover";
            this.panel_LogCover.Size = new System.Drawing.Size(436, 237);
            this.panel_LogCover.TabIndex = 1;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Log.Font = new System.Drawing.Font("微软雅黑", 8.25F);
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Log.Size = new System.Drawing.Size(434, 235);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.TextChanged += new System.EventHandler(this.richTextBox_Log_TextChanged);
            // 
            // menuStrip_LogTab
            // 
            this.menuStrip_LogTab.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_LogTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LogCopy,
            this.toolStripMenuItem_LogClear});
            this.menuStrip_LogTab.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_LogTab.Name = "menuStrip_LogTab";
            this.menuStrip_LogTab.Size = new System.Drawing.Size(436, 25);
            this.menuStrip_LogTab.TabIndex = 0;
            this.menuStrip_LogTab.Text = "menuStrip2";
            // 
            // toolStripMenuItem_LogCopy
            // 
            this.toolStripMenuItem_LogCopy.Name = "toolStripMenuItem_LogCopy";
            this.toolStripMenuItem_LogCopy.Size = new System.Drawing.Size(72, 21);
            this.toolStripMenuItem_LogCopy.Text = "로그 복사";
            this.toolStripMenuItem_LogCopy.Click += new System.EventHandler(this.toolStripMenuItem_LogCopy_Click);
            // 
            // toolStripMenuItem_LogClear
            // 
            this.toolStripMenuItem_LogClear.Name = "toolStripMenuItem_LogClear";
            this.toolStripMenuItem_LogClear.Size = new System.Drawing.Size(72, 21);
            this.toolStripMenuItem_LogClear.Text = "로그 삭제";
            this.toolStripMenuItem_LogClear.Click += new System.EventHandler(this.toolStripMenuItem_LogClear_Click);
            // 
            // tabPage_devmode
            // 
            this.tabPage_devmode.AutoScroll = true;
            this.tabPage_devmode.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_devmode.Controls.Add(this.groupBox_network_settings);
            this.tabPage_devmode.Controls.Add(this.groupBox_debug_settings);
            this.tabPage_devmode.Location = new System.Drawing.Point(114, 4);
            this.tabPage_devmode.Name = "tabPage_devmode";
            this.tabPage_devmode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_devmode.Size = new System.Drawing.Size(436, 262);
            this.tabPage_devmode.TabIndex = 4;
            this.tabPage_devmode.Text = "개발자 모드";
            // 
            // groupBox_network_settings
            // 
            this.groupBox_network_settings.Controls.Add(this.checkBox_netFilter);
            this.groupBox_network_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_network_settings.Location = new System.Drawing.Point(3, 74);
            this.groupBox_network_settings.Name = "groupBox_network_settings";
            this.groupBox_network_settings.Size = new System.Drawing.Size(430, 71);
            this.groupBox_network_settings.TabIndex = 10;
            this.groupBox_network_settings.TabStop = false;
            this.groupBox_network_settings.Text = "网络";
            // 
            // checkBox_netFilter
            // 
            this.checkBox_netFilter.AutoSize = true;
            this.checkBox_netFilter.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_netFilter.Location = new System.Drawing.Point(19, 24);
            this.checkBox_netFilter.Name = "checkBox_netFilter";
            this.checkBox_netFilter.Size = new System.Drawing.Size(291, 21);
            this.checkBox_netFilter.TabIndex = 8;
            this.checkBox_netFilter.Text = "过滤网络连接（屏蔽部分第三方工具的互相影响）";
            this.checkBox_netFilter.UseVisualStyleBackColor = true;
            this.checkBox_netFilter.CheckedChanged += new System.EventHandler(this.checkBox_netFilter_CheckedChanged);
            // 
            // groupBox_debug_settings
            // 
            this.groupBox_debug_settings.Controls.Add(this.checkBox_DevMode);
            this.groupBox_debug_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_debug_settings.Location = new System.Drawing.Point(3, 3);
            this.groupBox_debug_settings.Name = "groupBox_debug_settings";
            this.groupBox_debug_settings.Size = new System.Drawing.Size(430, 71);
            this.groupBox_debug_settings.TabIndex = 9;
            this.groupBox_debug_settings.TabStop = false;
            this.groupBox_debug_settings.Text = "调试";
            // 
            // checkBox_DevMode
            // 
            this.checkBox_DevMode.AutoSize = true;
            this.checkBox_DevMode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox_DevMode.Location = new System.Drawing.Point(19, 24);
            this.checkBox_DevMode.Name = "checkBox_DevMode";
            this.checkBox_DevMode.Size = new System.Drawing.Size(91, 21);
            this.checkBox_DevMode.TabIndex = 8;
            this.checkBox_DevMode.Text = "개발자 모드";
            this.checkBox_DevMode.UseVisualStyleBackColor = true;
            this.checkBox_DevMode.CheckedChanged += new System.EventHandler(this.checkBox_DevMode_CheckedChanged);
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Info.Controls.Add(this.label_About);
            this.tabPage_Info.Controls.Add(this.linkLabel_GitHub);
            this.tabPage_Info.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Size = new System.Drawing.Size(436, 262);
            this.tabPage_Info.TabIndex = 3;
            this.tabPage_Info.Text = "정보";
            // 
            // label_About
            // 
            this.label_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_About.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label_About.Location = new System.Drawing.Point(0, 0);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(436, 210);
            this.label_About.TabIndex = 0;
            this.label_About.Text = "[제작 및 문의]\r\n유채색\r\n라그린네\r\n히비야\r\n\r\n[저작권]\r\n기재되어있는 회사명 · 제품명 · 시스템 이름은\r\n해당 소유자의 상표 또는 등록 " +
    "상표입니다.\r\n(C) 2010 - 2017 SQUARE ENIX CO., LTD All Rights Reserved.\r\nKorea Publish" +
    "ed by EYEDENTITY MOBILE.";
            this.label_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel_GitHub.Location = new System.Drawing.Point(0, 210);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(436, 52);
            this.linkLabel_GitHub.TabIndex = 0;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "Original Author: GitHub";
            this.linkLabel_GitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GitHub_LinkClicked);
            // 
            // label_AboutTitle
            // 
            this.label_AboutTitle.BackColor = System.Drawing.Color.Silver;
            this.label_AboutTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_AboutTitle.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_AboutTitle.ForeColor = System.Drawing.Color.Gray;
            this.label_AboutTitle.Location = new System.Drawing.Point(0, 297);
            this.label_AboutTitle.Name = "label_AboutTitle";
            this.label_AboutTitle.Size = new System.Drawing.Size(554, 24);
            this.label_AboutTitle.TabIndex = 0;
            this.label_AboutTitle.Text = "VERSION STRING";
            this.label_AboutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label_AboutTitle);
            this.Controls.Add(this.panel_TopSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::App.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "임무/돌발 찾기 도우미";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel_TopSetting.ResumeLayout(false);
            this.panel_TopSetting.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.tabControl_Settings.ResumeLayout(false);
            this.settings_basic.ResumeLayout(false);
            this.settings_basic.PerformLayout();
            this.settings_advanced.ResumeLayout(false);
            this.settings_advanced.PerformLayout();
            this.settings_eureka_tracker.ResumeLayout(false);
            this.settings_eureka_tracker.PerformLayout();
            this.settings_tts.ResumeLayout(false);
            this.settings_tts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tts_vol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tts_speed)).EndInit();
            this.settings_update.ResumeLayout(false);
            this.settings_update.PerformLayout();
            this.tabPage_FATE.ResumeLayout(false);
            this.tabPage_FATE.PerformLayout();
            this.menuStrip_FATETab.ResumeLayout(false);
            this.menuStrip_FATETab.PerformLayout();
            this.tabPage_Log.ResumeLayout(false);
            this.tabPage_Log.PerformLayout();
            this.panel_LogCover.ResumeLayout(false);
            this.menuStrip_LogTab.ResumeLayout(false);
            this.menuStrip_LogTab.PerformLayout();
            this.tabPage_devmode.ResumeLayout(false);
            this.groupBox_network_settings.ResumeLayout(false);
            this.groupBox_network_settings.PerformLayout();
            this.groupBox_debug_settings.ResumeLayout(false);
            this.groupBox_debug_settings.PerformLayout();
            this.tabPage_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
        private System.Windows.Forms.CheckBox checkBox_Overlay;
        private LocalizableLabel label_AboutTitle;
        private System.Windows.Forms.Button button_ResetOverlayPosition;
        private System.Windows.Forms.Button button_SelectProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.CheckBox checkBox_StartupShow;
        private System.Windows.Forms.ComboBox comboBox_Process;
        private System.Windows.Forms.Button button_ResetProcess;
        internal RikTheVeggie.TriStateTreeView triStateTreeView_FATEs;
        private System.Windows.Forms.Panel panel_TopSetting;
        private LocalizableLabel label_Process;
        private TabControlBlack tabControl;
        private System.Windows.Forms.TabPage tabPage_FATE;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.MenuStrip menuStrip_FATETab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_UnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectApply;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.Panel panel_LogCover;
        private System.Windows.Forms.MenuStrip menuStrip_LogTab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LogCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LogClear;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPage_Info;
        private LocalizableLabel label_About;
        private System.Windows.Forms.CheckBox checkBox_AutoOverlayHide;
        internal System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox checkBox_FlashWindow;
        private System.Windows.Forms.ToolStripMenuItem presetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfireIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfireIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfNetherfireIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfallIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfallIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfNetherfireIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkywindIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkywindIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyearthIToolStripMenuItem;
        private LocalizableLabel label_FATEAbout;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem IxionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TamamoToolStripMenuItem;
        private System.Windows.Forms.Button button_SoundLocation;
        private System.Windows.Forms.CheckBox checkBox_PlaySound;
        private LocalizableLabel label_SoundLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox_TTS;
        private System.Windows.Forms.TabPage tabPage_devmode;
        private System.Windows.Forms.CheckBox checkBox_DevMode;
        private System.Windows.Forms.GroupBox groupBox_debug_settings;
        private System.Windows.Forms.TabControl tabControl_Settings;
        private System.Windows.Forms.TabPage settings_basic;
        private System.Windows.Forms.TabPage settings_update;
        private System.Windows.Forms.ComboBox comboBox_dfaUpdate;
        private LocalizableLabel update_about;
        private System.Windows.Forms.ComboBox comboBox_dataUpdate;
        private LocalizableLabel update_data_about;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TabPage settings_eureka_tracker;
        private System.Windows.Forms.CheckBox checkBox_tracker_auto;
        private System.Windows.Forms.Button button_tracker_open;
        private System.Windows.Forms.CheckBox checkBox_tracker_enabled;
        private System.Windows.Forms.CheckBox checkBox_UpdateCheckBeta;
        private System.Windows.Forms.TabPage settings_tts;
        private System.Windows.Forms.ComboBox comboBox_tts_cache;
        private System.Windows.Forms.Button button_tts_clear_cache;
        private LocalizableLabel tts_cache;
        private System.Windows.Forms.TextBox textBox_tts_speed;
        private LocalizableLabel tts_speed;
        private System.Windows.Forms.TrackBar trackBar_tts_speed;
        private System.Windows.Forms.Button button_tts_test;
        private System.Windows.Forms.CheckBox checkBox_RoulleteTips;
        private System.Windows.Forms.CheckBox checkBox_tracker_CNmirror;
        private System.Windows.Forms.GroupBox groupBox_network_settings;
        private System.Windows.Forms.CheckBox checkBox_netFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TabPage settings_advanced;
        private System.Windows.Forms.CheckBox checkBox_CheatRoullete;
        private System.Windows.Forms.CheckBox checkBox_HeartBeatLock;
        private System.Windows.Forms.TextBox textBox_tts_vol;
        private LocalizableLabel tts_vol;
        private System.Windows.Forms.TrackBar trackBar_tts_vol;
        private System.Windows.Forms.Button button_Sound_Stop;
    }
}

