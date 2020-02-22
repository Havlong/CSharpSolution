using System;
using System.Text.RegularExpressions;

namespace App1
{
    internal static class MainProgram
    {
        private static void Main()
        {
            var student = new Student();
            Console.WriteLine("Эта программа позволяет сформировать данные о студенте");
            Console.WriteLine("Пожалуйста, введите информацию об университете:");
            student.University = Console.ReadLine()?.Trim();
            while (string.IsNullOrEmpty(student.University))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                student.University = Console.ReadLine()?.Trim();
            }

            Console.WriteLine("Пожалуйста, введите информацию о факультете:");
            student.Faculty = Console.ReadLine()?.Trim();
            while (string.IsNullOrEmpty(student.Faculty))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                student.Faculty = Console.ReadLine()?.Trim();
            }

            Console.WriteLine("Пожалуйста, введите информацию о кафедре:");
            student.Department = Console.ReadLine()?.Trim();
            while (string.IsNullOrEmpty(student.Department))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                student.Department = Console.ReadLine()?.Trim();
            }

            Console.WriteLine("Пожалуйста, введите информацию о форме обучения:");
            Console.WriteLine("1, если форма очная");
            Console.WriteLine("0, если форма заочная");
            var buffer = Console.ReadLine()?.Trim();
            while (buffer == null || buffer != "1" && buffer != "0")
            {
                Console.WriteLine("Попробуйте ещё раз:");
                buffer = Console.ReadLine()?.Trim();
            }

            student.IsFullTime = buffer == "1";
            Console.WriteLine("Пожалуйста, введите информацию о среднем балле:");
            buffer = Console.ReadLine()?.Trim();
            while (buffer == null || !Regex.IsMatch(buffer, "^(([2-4]([.,]\\d+)?)|(5([.,]0+)?))$"))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                buffer = Console.ReadLine()?.Trim();
            }

            student.AverageMark = double.Parse(buffer.Replace('.', ','));

            Console.WriteLine("Пожалуйста, введите информацию о курсе обучения:");
            buffer = Console.ReadLine()?.Trim();
            while (buffer == null || !Regex.IsMatch(buffer, "^[1-4]$"))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                buffer = Console.ReadLine()?.Trim();
            }

            student.Form = int.Parse(buffer);

            Console.WriteLine("Пожалуйста, введите информацию о номере зачётки:");
            buffer = Console.ReadLine()?.Trim();
            while (buffer == null || !Regex.IsMatch(buffer, "^\\d+$"))
            {
                Console.WriteLine("Попробуйте ещё раз:");
                buffer = Console.ReadLine()?.Trim();
            }

            student.Id = int.Parse(buffer);

            Console.WriteLine("Данные успешно сформированы: ");
            Console.WriteLine(student);
            Console.WriteLine($"Особое внимание уделено хранению номера зачётки, введённому как: {student.Id}");
            student.PrintId();
        }
    }
}