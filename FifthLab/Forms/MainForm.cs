using System;
using System.Timers;
using System.Windows.Forms;
using FifthLab.Classes;
using Timer = System.Timers.Timer;

namespace FifthLab.Forms
{
    public partial class MainForm : Form
    {
        private MainClass _main = MainClass.GetInstance();

        public MainForm()
        {
            InitializeComponent();

            Timer timer = new Timer(5000);
            timer.AutoReset = true;
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs args)
        {
            _main.ListOfStudents++;
            UpdateInfo();
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
    }
}