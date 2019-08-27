using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace daftar_belanja
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string nama;
        public static string alamat;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
