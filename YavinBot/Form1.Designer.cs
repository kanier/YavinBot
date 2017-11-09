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
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.out_min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.CustomForeColor = true;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_status.Location = new System.Drawing.Point(0, 43);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(132, 19);
            this.lbl_status.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Бот не запущен...";
            this.lbl_status.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // out_min
            // 
            this.out_min.AutoSize = true;
            this.out_min.Location = new System.Drawing.Point(13, 13);
            this.out_min.Name = "out_min";
            this.out_min.Size = new System.Drawing.Size(36, 13);
            this.out_min.TabIndex = 2;
            this.out_min.Text = "Empty";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(164, 62);
            this.Controls.Add(this.out_min);
            this.Controls.Add(this.lbl_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(180, 100);
            this.MinimumSize = new System.Drawing.Size(180, 100);
            this.Name = "Form1";
            this.Text = "YavinBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_status;
        private System.Windows.Forms.Label out_min;
    }
}

