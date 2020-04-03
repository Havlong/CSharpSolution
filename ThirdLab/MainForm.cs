﻿using System;
using System.Windows.Forms;

namespace ThirdLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void interactiveButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Interactive();
            myForm.Show();
            Hide();
        }

        private void comparisonButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Comparison();
            myForm.Show();
            Hide();
        }
    }
}