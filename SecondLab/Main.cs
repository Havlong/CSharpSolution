using System.Text.RegularExpressions;

namespace SecondLab
{
    public class Main
    {
        private static readonly Main Instance = new Main();

        public static Main GetInstance()
        {
            return Instance;
        }

        private Main()
        {
        }

        public void AddStudent(string university, string faculty, string department, bool isFullTime, int form,
            double averageMark, int id)
        {
            Student.ListOfStudents.Add(Student.IntToHex(id), new Student(university, faculty, department, isFullTime,
                form, averageMark, id));
            Student.AmountOfStudents++;
        }

        public bool IsStudentExist(int id)
        {
            return Student.ListOfStudents.ContainsKey(Student.IntToHex(id));
        }

        public void ChangeStudent(string university, string faculty, string department, bool isFullTime, int form,
            double averageMark, int id)
        {
            Student student = Student.ListOfStudents[Student.IntToHex(id)];

            student.University = university;
            student.Faculty = faculty;
            student.Department = department;
            student.IsFullTime = isFullTime;
            student.Form = form;
            student.AverageMark = averageMark;
        }
    }
}