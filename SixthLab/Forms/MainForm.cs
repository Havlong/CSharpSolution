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
                int number = _main.Rnd.Next(0, 100);
                _main.MakeToast("OK", $"{number} * 3 = {(int)_main.Triple(number)}");
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
                _main.MakeToast("OK", $"Result is {_main.Triple("Hello world")}");
            }
            catch (Exception exception)
            {
                _main.MakeToast("Error", exception.ToString());
            }
        }
    }
}