using System;
using System.Windows.Forms;
using SixthLab.Classes;

namespace SixthLab.Forms
{
    public partial class MainForm : Form
    {
        private MainClass _main = MainClass.GetInstance();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CallInt_Click(object sender, EventArgs e)
        {
            try
            {
                _main.Triple(_main.Rnd.Next(0, 100));
            }
            catch (Exception exception)
            {
                _main.MakeToast("Error", exception.ToString());
            }
            
        }

        private void CallString_Click(object sender, EventArgs e)
        {
            try
            {
                _main.Triple("Hello world!");
            }
            catch (Exception exception)
            {
                _main.MakeToast("Error", exception.ToString());
            }
        }
    }
}