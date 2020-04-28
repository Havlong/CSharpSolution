using System;
using System.Windows.Forms;
using EighthLab.Classes;

namespace EighthLab.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private MainClass _main = MainClass.GetInstance();

        private void UpdateInfo()
        {
            var list = _main.ListOfDictionaries;
            collectionsList.Items.Clear();

            foreach (var el in list)
            {
                collectionsList.Items.Add(el.ToString());
            }
        }

        private void AddCollectionButton_Click(object sender, EventArgs e)
        {
            _main.GenerateStudentsCollection();
            UpdateInfo();
        }


        private void CountCollectionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"{_main.GetCountOfCollectionsWithId((int)idBox.Value)}");
        }

        private void MaxCollectionButton_Click(object sender, EventArgs e)
        {
            var x = _main.FindMaxDictWithId((int)idBox.Value);

            if (x != null)
            {
                MessageBox.Show(
                    $"Коллекция найдёна! {x}");
            }
            else
            {
                MessageBox.Show(
                    $"Коллекция не найдена!");
            }
        }
    }
}