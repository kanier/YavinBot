using System;
using System.Windows.Forms;

namespace YavinBot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        //string temp_text;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = Program.Title.Value;
            richTextBox1.Lines = YavinBot.Program.Data.Value;
            
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            
            string path = YavinBot.Program.Path.Value;
            System.IO.File.WriteAllLines(YavinBot.Program.Path.Value, richTextBox1.Lines);
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string t_path = Program.Title.Value;
            string app_path = YavinBot.Program.AppPath.Value;
            string path = Program.Path.Value;
            string e_path = t_path.Replace("/","\\");
            //MessageBox.Show(@app_path+"\\"+e_path);
            System.Diagnostics.Process.Start(@app_path+"\\"+e_path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string app_path = YavinBot.Program.AppPath.Value;
            System.Diagnostics.Process.Start(@app_path);
        }
    }
}
