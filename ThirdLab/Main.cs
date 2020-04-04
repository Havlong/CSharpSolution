using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ThirdLab
{
    struct Pair<TKey, TValue>
    {
        public TKey First { get; set; }
        public TValue Second { get; set; }

        public Pair(TKey first, TValue second)
        {
            this.First = first;
            this.Second = second;
        }
    }

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

        public Queue<Student> QOfStudents = new Queue<Student>();

        public bool IsLetterEntered(string s)
        {
            Regex regex = new Regex(@"[a-zа-яA-ZА-Я]+");
            MatchCollection matches = regex.Matches(s);
            return matches.Count != 0;
        }

        public bool IsStudentExist(int id)
        {
            bool toReturn = false;

            foreach (var student in QOfStudents)
                if (student.Id == id)
                    toReturn = true;

            return toReturn;
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

        public long Pop()
        {
            Stopwatch startTime;
            startTime = Stopwatch.StartNew();
            
            if (QOfStudents.Count != 0)
            {
                QOfStudents.Dequeue();
            }

            startTime.Stop();
            var leadTime = startTime.ElapsedTicks;

            return leadTime;
        }

        public long AddStudent(string university, string faculty, string department, bool isFullTime, int form,
            double averageMark, int id)
        {
            Stopwatch startTime;
            startTime = Stopwatch.StartNew();
            
            Student student = new Student(university, faculty, department, isFullTime, form, averageMark, id);
            QOfStudents.Enqueue(student);
            
            startTime.Stop();
            var leadTime = startTime.ElapsedTicks;

            return leadTime;
        }

        public long GenerateStudentsForQ(int n)
        {
            Stopwatch startTime;
            startTime = Stopwatch.StartNew();
            var q = new Queue<Student>();
            
            for (int i = 0; i < n; i++)
            {
                q.Enqueue(new Student(i + 1));
            }
            
            startTime.Stop();
            var leadTime = startTime.ElapsedTicks;

            return leadTime;
        }

        public long GenerateStudentsForArr(int n)
        {
            Stopwatch startTime;
            startTime = Stopwatch.StartNew();
            Student[] arr = new Student[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Student(i + 1);
            }
            
            startTime.Stop();
            var leadTime = startTime.ElapsedTicks;

            return leadTime;
        }
    }
}