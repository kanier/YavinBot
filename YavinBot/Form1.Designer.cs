namespace YavinBot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnRun = new MetroFramework.Controls.MetroButton();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRun.Highlight = true;
            this.BtnRun.Location = new System.Drawing.Point(20, 60);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(140, 48);
            this.BtnRun.Style = MetroFramework.MetroColorStyle.Lime;
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "Ручной ReRoll";
            this.BtnRun.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click_1);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.CustomForeColor = true;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_status.Location = new System.Drawing.Point(20, 111);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(132, 19);
            this.lbl_status.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Бот не запущен...";
            this.lbl_status.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(180, 150);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.lbl_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(180, 150);
            this.MinimumSize = new System.Drawing.Size(180, 150);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "YavinBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnRun;
        private MetroFramework.Controls.MetroLabel lbl_status;
    }
}

