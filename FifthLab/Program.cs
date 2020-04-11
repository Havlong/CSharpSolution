using System;
using System.Windows.Forms;
using FifthLab.Classes;
using FifthLab.Forms;

namespace FifthLab
{
    static class Program
    {
        private static MainClass _main = MainClass.GetInstance();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}