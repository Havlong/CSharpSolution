using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FifthLab.Classes
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
        }

        public MyDictionary ListOfStudents = new MyDictionary();

        public bool IsStudentExist(int id)
        {
            return ListOfStudents.ContainsKey(id);
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
    }
}