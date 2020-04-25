using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SeventhLab.Classes
{
    public class MainClass
    {
        private static MainClass _instance;

        public static MainClass GetInstance()
        {
            return _instance ?? (_instance = new MainClass());
        }

        private MainClass()
        {
            ListOfStudents.OnAdd += (id, student) =>
            {
                MessageBox.Show(
                    $"Student with id {id} successfully added!");
            };
            
            ListOfStudents.OnRemove += (id, student) =>
            {
                MessageBox.Show(
                    $"Student with id {id} successfully removed!");
            };
        }
        
        public MyDictionary ListOfStudents = new MyDictionary();

        public bool IsStudentExist(int id)
        {
            return ListOfStudents.ContainsKey(id);
        }
    }
}