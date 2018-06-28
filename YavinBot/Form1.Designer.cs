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
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_txt = new System.Windows.Forms.RichTextBox();
            this.count_lbl = new System.Windows.Forms.Label();
            this.err_lbl = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.pit_lbl = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.side_pnl = new System.Windows.Forms.Panel();
            this.aat_btn = new System.Windows.Forms.Label();
            this.solo_btn = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.open_btn = new System.Windows.Forms.Button();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(470, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 20);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.BackColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(484, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(14, 13);
            this.lbl_close.TabIndex = 8;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_out_Click);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.BackColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(459, 9);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(19, 13);
            this.lbl_min.TabIndex = 9;
            this.lbl_min.Text = "__";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::YavinBot.Properties.Resources.EVA_full;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // txt_txt
            // 
            this.txt_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_txt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_txt.Location = new System.Drawing.Point(267, 49);
            this.txt_txt.Name = "txt_txt";
            this.txt_txt.Size = new System.Drawing.Size(181, 156);
            this.txt_txt.TabIndex = 10;
            this.txt_txt.Text = "";
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.BackColor = System.Drawing.Color.White;
            this.count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_lbl.ForeColor = System.Drawing.Color.Green;
            this.count_lbl.Location = new System.Drawing.Point(15, 10);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(75, 20);
            this.count_lbl.TabIndex = 11;
            this.count_lbl.Text = "Запросы";
            this.count_lbl.Click += new System.EventHandler(this.count_lbl_Click);
            // 
            // err_lbl
            // 
            this.err_lbl.AutoSize = true;
            this.err_lbl.BackColor = System.Drawing.Color.White;
            this.err_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.err_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.err_lbl.Location = new System.Drawing.Point(15, 130);
            this.err_lbl.Name = "err_lbl";
            this.err_lbl.Size = new System.Drawing.Size(69, 20);
            this.err_lbl.TabIndex = 12;
            this.err_lbl.Text = "Ошибки";
            this.err_lbl.Click += new System.EventHandler(this.Err_lbl_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.Color.White;
            this.lbl_1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_1.Location = new System.Drawing.Point(414, 221);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(50, 17);
            this.lbl_1.TabIndex = 13;
            this.lbl_1.Text = "Статус";
            // 
            // pit_lbl
            // 
            this.pit_lbl.AutoSize = true;
            this.pit_lbl.BackColor = System.Drawing.Color.White;
            this.pit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pit_lbl.ForeColor = System.Drawing.Color.Green;
            this.pit_lbl.Location = new System.Drawing.Point(15, 70);
            this.pit_lbl.Name = "pit_lbl";
            this.pit_lbl.Size = new System.Drawing.Size(41, 20);
            this.pit_lbl.TabIndex = 14;
            this.pit_lbl.Text = "Яма";
            this.pit_lbl.Click += new System.EventHandler(this.pit_lbl_Click);
            // 
            // side_pnl
            // 
            this.side_pnl.BackColor = System.Drawing.Color.White;
            this.side_pnl.Controls.Add(this.aat_btn);
            this.side_pnl.Controls.Add(this.count_lbl);
            this.side_pnl.Controls.Add(this.solo_btn);
            this.side_pnl.Controls.Add(this.pit_lbl);
            this.side_pnl.Controls.Add(this.err_lbl);
            this.side_pnl.Location = new System.Drawing.Point(500, 49);
            this.side_pnl.Name = "side_pnl";
            this.side_pnl.Size = new System.Drawing.Size(104, 156);
            this.side_pnl.TabIndex = 15;
            this.side_pnl.Visible = false;
            // 
            // aat_btn
            // 
            this.aat_btn.AutoSize = true;
            this.aat_btn.BackColor = System.Drawing.Color.White;
            this.aat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aat_btn.ForeColor = System.Drawing.Color.Green;
            this.aat_btn.Location = new System.Drawing.Point(15, 100);
            this.aat_btn.Name = "aat_btn";
            this.aat_btn.Size = new System.Drawing.Size(40, 20);
            this.aat_btn.TabIndex = 16;
            this.aat_btn.Text = "ААТ";
            this.aat_btn.Click += new System.EventHandler(this.aat_btn_Click);
            // 
            // solo_btn
            // 
            this.solo_btn.AutoSize = true;
            this.solo_btn.BackColor = System.Drawing.Color.White;
            this.solo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solo_btn.ForeColor = System.Drawing.Color.Green;
            this.solo_btn.Location = new System.Drawing.Point(15, 40);
            this.solo_btn.Name = "solo_btn";
            this.solo_btn.Size = new System.Drawing.Size(48, 20);
            this.solo_btn.TabIndex = 15;
            this.solo_btn.Text = "Соло";
            this.solo_btn.Click += new System.EventHandler(this.solo_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.White;
            this.open_btn.FlatAppearance.BorderSize = 0;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_btn.Location = new System.Drawing.Point(478, 49);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(20, 30);
            this.open_btn.TabIndex = 16;
            this.open_btn.Text = ">";
            this.open_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            this.open_btn.MouseEnter += new System.EventHandler(this.open_btn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(608, 253);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_txt);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.side_pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-100, -100);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YavinBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.side_pnl.ResumeLayout(false);
            this.side_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.RichTextBox txt_txt;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label err_lbl;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label pit_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel side_pnl;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Label solo_btn;
        private System.Windows.Forms.Label aat_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}

