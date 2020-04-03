﻿using System;
using System.Windows.Forms;

namespace ThirdLab
{
    public partial class Comparison : Form
    {
        private Main _main = Main.GetInstance();

        public Comparison()
        {
            InitializeComponent();
        }

        private void Comparison_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            if (_main.IsLetterEntered(nBox.Text))
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
            if (nBox.Text == "")
            {
                MessageBox.Show(
                    "Введите n!",
                    "Как же так?",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            int n = int.Parse(nBox.Text);
            if (n < 3)
            {
                MessageBox.Show(
                    "N должно быть больше двух!",
                    "Возмутительно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            leadTimeList.Items.Add($"При n = {n}");
            leadTimeList.Items.Add($"Время выполнения операций в очереди = {_main.GenerateStudentsForQ(n)} тиков");
            leadTimeList.Items.Add($"Время выполнения операций в массиве = {_main.GenerateStudentsForArr(n)} тиков");
            leadTimeList.Items.Add("");
        }
    }
}