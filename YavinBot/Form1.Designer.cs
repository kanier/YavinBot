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
            this.BtnRun = new MetroFramework.Controls.MetroButton();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.list_out = new System.Windows.Forms.RichTextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRun.Highlight = true;
            this.BtnRun.Location = new System.Drawing.Point(20, 180);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(280, 50);
            this.BtnRun.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "Гогого!";
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
            this.lbl_status.Location = new System.Drawing.Point(20, 241);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(132, 19);
            this.lbl_status.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Бот не запущен...";
            this.lbl_status.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // list_out
            // 
            this.list_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_out.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_out.Location = new System.Drawing.Point(20, 60);
            this.list_out.Name = "list_out";
            this.list_out.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.list_out.Size = new System.Drawing.Size(280, 120);
            this.list_out.TabIndex = 2;
            this.list_out.Text = "";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.list_out);
            this.Controls.Add(this.lbl_status);
            this.MaximumSize = new System.Drawing.Size(320, 280);
            this.MinimumSize = new System.Drawing.Size(320, 280);
            this.Name = "Form1";
            this.Text = "YavinBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnRun;
        private MetroFramework.Controls.MetroLabel lbl_status;
        private System.Windows.Forms.RichTextBox list_out;
        private System.Diagnostics.EventLog eventLog1;
    }
}

