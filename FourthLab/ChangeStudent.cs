using System;
using System.Globalization;
using System.Windows.Forms;

namespace FourthLab
{
    public partial class ChangeStudent : Form
    {
        private Main _main = Main.GetInstance();

        public ChangeStudent()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void ChangeStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void UpdateInfo()
        {
            foreach (var key in _main.ListOfStudents.Keys)
            {
                comboIdBox.Items.Add(key);
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

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (comboIdBox.Text == "")
            {
                MessageBox.Show(
                    "Невозможно изменить студента. Их ещё не существует!",
                    "Ну вы конечно даа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int id = int.Parse(comboIdBox.Text);

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

            double averageMark = _main.ReturnAndCheckMark(averageMarkBox.Text);

            bool isFullTime = isFullTimeCheckBox.Checked;

            _main.ChangeUniversityStudent(id, course, averageMark, university, faculty, department, isFullTime);

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
                    "Невозможно изменить студента. Их ещё не существует!",
                    "Ну вы конечно даа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int id = int.Parse(comboIdBox.Text);
            
            var student = _main.ListOfStudents[id];

            universityBox.Text = student.University;
            facultyBox.Text = student.Faculty;
            departmentBox.Text = student.Department;
            courseBox.Text = student.Course.ToString();
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