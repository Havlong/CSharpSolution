using System;
using System.Windows.Forms;

namespace FourthLab
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            var newForm = new ChangeStudent();
            newForm.Show();
            Hide();
        }

        private void showClassesButton_Click(object sender, EventArgs e)
        {
            var newForm = new ShowClasses();
            newForm.Show();
            Hide();
        }
    }
}