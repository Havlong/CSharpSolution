using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecondLab
{
    public partial class ShowStudent : Form
    {
        private Main _main = Main.GetInstance();

        public ShowStudent()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void ShowStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void UpdateInfo()
        {
            foreach (var key in Student.ListOfStudents.Keys)
            {
                comboIdBox.Items.Add(key);
            }
            countStudentsLabel.Text = Student.AmountOfStudents.ToString();
        }

        private bool IsLetterEntered(string s)
        {
            Regex regex = new Regex(@"[a-zа-яA-ZА-Я]+");
            MatchCollection matches = regex.Matches(s);
            return matches.Count != 0;
        }

        private void comboIdBox_TextChanged(object sender, EventArgs e)
        {
            if (IsLetterEntered(comboIdBox.Text))
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
            if (IsLetterEntered(averageMarkBox.Text))
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
            if (IsLetterEntered(courseBox.Text))
            {
                MessageBox.Show(
                    "Вы ввели букву! Это неприемлемо!",
                    "Возмутительно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private int ReturnAndCheckId(string s)
        {
            int id;
            if (IsLetterEntered(s))
            {
                id = 1;
            }
            else
            {
                id = int.Parse(s);
            }

            if (!_main.IsStudentExist(id))
            {
                MessageBox.Show(
                    "Студент не найден!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                id = -1;
            }

            return id;
        }

        private double ReturnAndCheckMark(string s)
        {
            double mark;
            
            if (IsLetterEntered(s))
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
            if (comboIdBox.Text == "")
            {
                MessageBox.Show(
                    "Невозможно изменить студента. Пожалуйста введите id",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            
            int id = ReturnAndCheckId(comboIdBox.Text);

            if (id == -1)
                return;

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
            if (IsLetterEntered(courseBox.Text))
            {
                course = 1;
            }
            else
            {
                course = int.Parse(courseBox.Text);
            }

            double averageMark = ReturnAndCheckMark(averageMarkBox.Text);

            bool isFullTime = isFullTimeCheckBox.Checked;

            _main.ChangeStudent(university, faculty, department, isFullTime, course, averageMark, id);

            MessageBox.Show(
                "Студент успешно изменён!",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            ClearField();
        }

        private void ClearField()
        {
            comboIdBox.Text = "";
            universityBox.Text = "";
            facultyBox.Text = "";
            departmentBox.Text = "";
            courseBox.Text = "";
            averageMarkBox.Text = "";
            isFullTimeCheckBox.Checked = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (comboIdBox.Text == "")
            {
                MessageBox.Show(
                    "Невозможно найти студента. Пожалуйста введите id",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            
            int id = ReturnAndCheckId(comboIdBox.Text);

            if (id == -1)
                return;

            Student student = Student.ListOfStudents[Student.IntToHex(id)];

            universityBox.Text = student.University;
            facultyBox.Text = student.Faculty;
            departmentBox.Text = student.Department;
            courseBox.Text = student.Form.ToString();
            averageMarkBox.Text = student.AverageMark.ToString(CultureInfo.CurrentCulture);
            isFullTimeCheckBox.Checked = student.IsFullTime;
            
            MessageBox.Show(
                "Студент найден!",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}