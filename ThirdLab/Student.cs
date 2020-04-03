﻿using System;
using System.Collections.Generic;

namespace ThirdLab
{
    public class Student
    {
        public Student()
        {
            Id = 1;
            Form = 2;
            University = "Пензенский Государственный Университет";
            IsFullTime = true;
            Faculty = "Вычислительной техники";
            AverageMark = 5;
            Department = "Математическое обеспечение и применение ЭВМ";
        }

        public Student(int id)
        {
            Form = 2;
            Id = id;
            University = "Пензенский Государственный Университет";
            IsFullTime = true;
            Faculty = "Вычислительной техники";
            AverageMark = 5;
            Department = "Математическое обеспечение и применение ЭВМ";
        }

        public Student(int form, int id)
        {
            Form = form;
            Id = id;
            University = "Пензенский Государственный Университет";
            IsFullTime = true;
            Faculty = "Вычислительной техники";
            AverageMark = 5;
            Department = "Математическое обеспечение и применение ЭВМ";
        }

        public Student(string university, string faculty, string department, bool isFullTime, int form,
            double averageMark, int id)
        {
            University = university;
            Faculty = faculty;
            Department = department;
            IsFullTime = isFullTime;
            Form = form;
            AverageMark = averageMark;
            Id = id;
        }

        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public bool IsFullTime { get; set; }
        public int Form { get; set; }
        public double AverageMark { get; set; }
        public int Id { get; set; }

        public static string IntToHex(int x)
        {
            return x.ToString("X");
        }
        
        public void PrintUniversity()
        {
            Console.WriteLine($"Университет: {University}");
        }

        public void PrintFaculty()
        {
            Console.WriteLine($"Факультет: {Faculty}");
        }

        public void PrintDepartment()
        {
            Console.WriteLine($"Кафедра: {Department}");
        }

        public void PrintIsFullTime()
        {
            Console.WriteLine($"Форма обучения: {(IsFullTime ? "Очная" : "Заочная")}");
        }

        public void PrintForm()
        {
            Console.WriteLine($"Курс: {Form}");
        }

        public void PrintAverageMark()
        {
            Console.WriteLine($"Средний балл: {AverageMark}");
        }

        public void PrintId()
        {
            Console.WriteLine($"Номер зачётки: {Id}");
        }

        public override string ToString()
        {
            return
                $"Университет: {University}\n" +
                $"Факультет: {Faculty}\n" +
                $"Кафедра: {Department}\n" +
                $"Форма обучения: {(IsFullTime ? "Очная" : "Заочная")}\n" +
                $"Курс: {Form}\n" +
                $"Средний балл: {AverageMark}\n" +
                $"Номер зачётки: {Id}";
        }
    }
}