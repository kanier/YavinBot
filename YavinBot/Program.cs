using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace YavinBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public class Data
        {
            public static string[] Value { get; set; }
        }
        public class Path
        {
            public static string Value { get; set; }
        }
        public class Title

        {
            public static string Value { get; set; }
        }
        public class AppPath
        {
            public static string Value { get; set; }
        }
        

    }
}
