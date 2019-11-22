namespace App
{
    partial class TrackerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_NT = new System.Windows.Forms.ToolStripDropDownButton();
            this.anemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hydatostoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnMain = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Tracker_Id = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_Go = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 634);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_NT,
            this.toolStripSeparator1,
            this.tsbtnMain,
            this.toolStripTextBox_Tracker_Id,
            this.toolStripButton_Go});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1104, 25);
            this.toolStrip1.TabIndex = 3;
            // 
            // toolStripButton_NT
            // 
            this.toolStripButton_NT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_NT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anemosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.pyrosToolStripMenuItem,
            this.hydatostoolStripMenuItem});
            this.toolStripButton_NT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NT.Name = "toolStripButton_NT";
            this.toolStripButton_NT.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton_NT.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton_NT.Text = "New Tracker";
            // 
            // anemosToolStripMenuItem
            // 
            this.anemosToolStripMenuItem.Name = "anemosToolStripMenuItem";
            this.anemosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anemosToolStripMenuItem.Text = "Anemos";
            this.anemosToolStripMenuItem.Click += new System.EventHandler(this.anemosToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // pyrosToolStripMenuItem
            // 
            this.pyrosToolStripMenuItem.Name = "pyrosToolStripMenuItem";
            this.pyrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pyrosToolStripMenuItem.Text = "Pyros";
            this.pyrosToolStripMenuItem.Click += new System.EventHandler(this.pyrosToolStripMenuItem_Click);
            // 
            // hydatostoolStripMenuItem
            // 
            this.hydatostoolStripMenuItem.Name = "hydatostoolStripMenuItem";
            this.hydatostoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hydatostoolStripMenuItem.Text = "Hydatos";
            this.hydatostoolStripMenuItem.Click += new System.EventHandler(this.hydatostoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnMain
            // 
            this.tsbtnMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMain.Name = "tsbtnMain";
            this.tsbtnMain.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbtnMain.Size = new System.Drawing.Size(69, 22);
            this.tsbtnMain.Text = "Tracker ID";
            // 
            // toolStripTextBox_Tracker_Id
            // 
            this.toolStripTextBox_Tracker_Id.Name = "toolStripTextBox_Tracker_Id";
            this.toolStripTextBox_Tracker_Id.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox_Tracker_Id.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton_Go
            // 
            this.toolStripButton_Go.AutoToolTip = false;
            this.toolStripButton_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Go.Name = "toolStripButton_Go";
            this.toolStripButton_Go.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton_Go.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton_Go.Text = "→";
            this.toolStripButton_Go.Click += new System.EventHandler(this.toolStripButton_Go_Click);
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = global::App.Properties.Resources.icon;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "TrackerForm";
            this.Opacity = 0D;
            this.Text = "DFAssist-Eureka-Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrackerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrackerForm_FormClosed);
            this.Load += new System.EventHandler(this.TrackerForm_Load);
            this.Shown += new System.EventHandler(this.TrackerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsbtnMain;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Tracker_Id;
        private System.Windows.Forms.ToolStripButton toolStripButton_Go;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton_NT;
        private System.Windows.Forms.ToolStripMenuItem anemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hydatostoolStripMenuItem;
    }
}