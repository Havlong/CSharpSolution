using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FourthLab
{
    public partial class ShowClasses : Form
    {
        private Main _main = Main.GetInstance();

        public ShowClasses()
        {
            InitializeComponent();
        }

        private void ShowClasses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }


        private void ShowClasses_Load(object sender, EventArgs e)
        {
            classesTree.BeginUpdate();
            int i = 0;
            foreach (var myClass in _main.GetClasses())
            {
                var allInfo = _main.GetAllInfoAboutClass(myClass);

                classesTree.Nodes.Add(myClass);

                int j = 0;
                foreach (var info in allInfo)
                {
                    classesTree.Nodes[i].Nodes.Add(info.Key);
                    foreach (var value in info.Value)
                    {
                        classesTree.Nodes[i].Nodes[j].Nodes.Add(value);
                    }
                    ++j;
                }

                ++i;
            }

            classesTree.EndUpdate();
        }
    }
}