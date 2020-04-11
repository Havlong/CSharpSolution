using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace FifthLab.Classes
{
    public class MyDictionary : Dictionary<int, UniversityStudent>
    {
        public static MyDictionary operator ++(MyDictionary dictionary)
        {
            int id;
            if (dictionary.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = dictionary.Keys.Max() + 1;
            }

            var student = new UniversityStudent(id);

            return dictionary + student;
        }
        
        public static MyDictionary operator --(MyDictionary dictionary)
        {
            dictionary.Remove(dictionary.Keys.Last());
            return dictionary;
        }

        public static MyDictionary operator +(MyDictionary dictionary, UniversityStudent student)
        {
            dictionary.Add(student.Id, student);
            return dictionary;
        }
    }
}