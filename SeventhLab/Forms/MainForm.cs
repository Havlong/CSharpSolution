using System;
using System.Windows.Forms;
using SeventhLab.Classes;

namespace SeventhLab.Forms
{
    public partial class MainForm : Form
    {
        private MainClass _main = MainClass.GetInstance();
        
        public MainForm()
        {
            InitializeComponent();
            _main.ListOfStudents.OnAdd += (id, student) => { UpdateInfo(); };
            _main.ListOfStudents.OnRemove += (id, student) => { UpdateInfo(); };
        }
        
        private void UpdateInfo()
        {
            var list = _main.ListOfStudents;
            studentsList.Items.Clear();

            foreach (var el in list)
            {
                studentsList.Items.Add(el.ToString());
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            _main.ListOfStudents++;
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            _main.ListOfStudents--;
        }
    }
}