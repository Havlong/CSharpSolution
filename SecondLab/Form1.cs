using System;
using System.Windows.Forms;

namespace SecondLab
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddStudent();
            newForm.Show();
            Hide();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var newForm = new ShowStudent();
            newForm.Show();
            Hide();
        }
    }
}