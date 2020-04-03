﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ThirdLab
{
    public partial class Interactive : Form
    {
        private Main _main = Main.GetInstance();

        public Interactive()
        {
            InitializeComponent();
        }

        private void Interactive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void UpdateInfo()
        {
            var q = _main.QOfStudents;
            studentsList.Items.Clear();
            int maxId = 0;

            foreach (var student in q)
            {
                studentsList.Items.Add(student.Id);
                
                if (student.Id > maxId)
                    maxId = student.Id;
            }
            
            if (q.Count == 0)
            {
                idBox.Text = "1";
            }
            else
            {
                idBox.Text = (maxId + 1).ToString();
            }
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
        
        private void addButton_Click(object sender, EventArgs e)
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

            double averageMark = _main.ReturnAndCheckMark(averageMarkBox.Text);

            bool isFullTime = isFullTimeCheckBox.Checked;

            clear.Text = _main.AddStudent(university, faculty, department, isFullTime, course, averageMark, id).ToString();
            
            UpdateInfo();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (_main.QOfStudents.Count == 0)
            {
                MessageBox.Show(
                    "В очереди нет студентов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                return;
            }

            clear.Text = _main.Pop().ToString();
            UpdateInfo();
        }

        private void showFirstButton_Click(object sender, EventArgs e)
        {
            if (_main.QOfStudents.Count == 0)
            {
                MessageBox.Show(
                    "В очереди нет студентов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                return;
            }
            
            var student = _main.QOfStudents.Peek();
            
            universityBox.Text = student.University;
            facultyBox.Text = student.Faculty;
            departmentBox.Text = student.Department;
            courseBox.Text = student.Form.ToString();
            averageMarkBox.Text = student.AverageMark.ToString(CultureInfo.CurrentCulture);
            isFullTimeCheckBox.Checked = student.IsFullTime;
        }
    }
}