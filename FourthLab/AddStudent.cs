using System;
using System.Linq;
using System.Windows.Forms;

namespace FourthLab
{
    public partial class AddStudent : Form
    {
        private Main _main = Main.GetInstance();

        public AddStudent()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (_main.ListOfStudents.Count == 0)
            {
                idBox.Text = "1";
            }
            else
            {
                idBox.Text = (_main.ListOfStudents.Keys.Max() + 1).ToString();
            }
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            if (_main.IsLetterEntered(idBox.Text))
            {
                MessageBox.Show(
                    "Вы ввели букву! Это неприемлемо!",
                    "Возмутительно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private void averageMarkBox_TextChanged(object sender, EventArgs e)
        {
            if (_main.IsLetterEntered(averageMarkBox.Text))
            {
                MessageBox.Show(
                    "Вы ввели букву! Это неприемлемо!",
                    "Возмутительно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private void courseBox_TextChanged(object sender, EventArgs e)
        {
            if (_main.IsLetterEntered(courseBox.Text))
            {
                MessageBox.Show(
                    "Вы ввели букву! Это неприемлемо!",
                    "Возмутительно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }
        
        private double ReturnAndCheckMark(string s)
        {
            double mark;
            
            if (_main.IsLetterEntered(s))
                mark = 4;
            else
                mark = double.Parse(s);

            if (mark > 5)
                mark = 5;
            else if (mark < 1)
                mark = 1;

            return mark;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show(
                    "Невозможно добавить студента. Пожалуйста введите id",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int id;
            
            if (_main.IsLetterEntered(idBox.Text))
            {
                id = 1;
            }
            else
            {
                id = int.Parse(idBox.Text);
            }

            if (_main.IsStudentExist(id))
            {
                MessageBox.Show(
                    "Невозможно добавить студента. Студент уже существует",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string university = universityBox.Text;
            if (university == "")
            {
                university = "ПГУ";
            }

            string faculty = facultyBox.Text;
            if (faculty == "")
            {
                faculty = "ФВТ";
            }

            string department = departmentBox.Text;
            if (university == "")
            {
                university = "МОиПЭВМ";
            }

            int course;
            if (_main.IsLetterEntered(courseBox.Text))
            {
                course = 1;
            }
            else
            {
                course = int.Parse(courseBox.Text);
            }

            double averageMark = ReturnAndCheckMark(averageMarkBox.Text);

            bool isFullTime = isFullTimeCheckBox.Checked;

            _main.AddUniversityStudent(id, course, averageMark, university, faculty, department, isFullTime);

            MessageBox.Show(
                "Студент успешно добавлен!",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateInfo();
        }
    }
}