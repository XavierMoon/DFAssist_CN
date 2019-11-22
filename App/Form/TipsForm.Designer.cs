namespace App
{
    partial class TipsForm
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
            this.panel_macro = new System.Windows.Forms.Panel();
            this.localizableLabel1 = new App.LocalizableLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_macro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_macro
            // 
            this.panel_macro.Controls.Add(this.localizableLabel1);
            this.panel_macro.Controls.Add(this.button1);
            this.panel_macro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_macro.Location = new System.Drawing.Point(0, 417);
            this.panel_macro.Name = "panel_macro";
            this.panel_macro.Size = new System.Drawing.Size(564, 84);
            this.panel_macro.TabIndex = 1;
            // 
            // localizableLabel1
            // 
            this.localizableLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localizableLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localizableLabel1.Location = new System.Drawing.Point(0, 0);
            this.localizableLabel1.Name = "localizableLabel1";
            this.localizableLabel1.Size = new System.Drawing.Size(450, 84);
            this.localizableLabel1.TabIndex = 1;
            this.localizableLabel1.Text = "该副本有可用的宏，是否复制？";
            this.localizableLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(450, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(564, 417);
            this.textBox1.TabIndex = 0;
            // 
            // TipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 501);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_macro);
            this.Icon = global::App.Properties.Resources.icon;
            this.MinimumSize = new System.Drawing.Size(380, 240);
            this.Name = "TipsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Duty Tips";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TipsForm_Load);
            this.Shown += new System.EventHandler(this.TipsForm_Shown);
            this.panel_macro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_macro;
        private LocalizableLabel localizableLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}