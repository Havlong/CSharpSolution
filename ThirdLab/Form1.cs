using System;
using System.Windows.Forms;

namespace ThirdLab
{
    public partial class Form1 : Form
    {
        private Main _main = new Main();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddStudent(_main);
            newForm.Show();
            Hide();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var newForm = new ShowStudent(_main);
            newForm.Show();
            Hide();
        }
    }
}