using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FourthLab
{
    public class Main
    {
        private static Main _instance;

        public static Main GetInstance()
        {
            return _instance ?? (_instance = new Main());
        }

        private Main()
        {
        }

        public Dictionary<int, UniversityStudent> ListOfStudents = new Dictionary<int, UniversityStudent>();

        public bool IsStudentExist(int id)
        {
            return ListOfStudents.ContainsKey(id);
        }

        public bool IsLetterEntered(string s)
        {
            Regex regex = new Regex(@"[a-zа-яA-ZА-Я]+");
            MatchCollection matches = regex.Matches(s);
            return matches.Count != 0;
        }

        public double ReturnAndCheckMark(string s)
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

        public void AddUniversityStudent(int id, int course, double averageMark, string university, string faculty,
            string department, bool isFullTime)
        {
            var newStudent =
                new UniversityStudent(university, faculty, department, isFullTime, course, averageMark, id);

            ListOfStudents.Add(id, newStudent);
        }

        public void ChangeUniversityStudent(int id, int course, double averageMark, string university, string faculty,
            string department, bool isFullTime)
        {
            var student = ListOfStudents[id];

            student.Course = course;
            student.AverageMark = averageMark;
            student.University = university;
            student.Faculty = faculty;
            student.Department = department;
            student.IsFullTime = isFullTime;
        }

        public List<string> GetClasses()
        {
            var myList = new List<string> {"FourthLab.AbstractStudent", "FourthLab.UniversityStudent"};
            return myList;
        }

        public Dictionary<string, List<string>> GetAllInfoAboutClass(string myClass)
        {
            var toReturn = new Dictionary<string, List<string>>();
            Type myType = Type.GetType(myClass, true, true);

            toReturn.Add("fields", new List<string>());
            foreach (var field in myType.GetFields())
            {
                toReturn["fields"].Add(field.Name);
            }

            toReturn.Add("constructors", new List<string>());
            foreach (var constructor in myType.GetConstructors())
            {
                toReturn["constructors"].Add(constructor.Name);
            }

            toReturn.Add("properties", new List<string>());
            foreach (var property in myType.GetProperties())
            {
                toReturn["properties"].Add(property.Name);
            }
            
            toReturn.Add("methods", new List<string>());
            foreach (var method in myType.GetMethods())
            {
                toReturn["methods"].Add(method.Name);
            }

            return toReturn;
        }
    }
}