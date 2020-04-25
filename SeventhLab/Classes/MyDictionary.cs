using System;
using System.Collections.Generic;
using System.Linq;

namespace SeventhLab.Classes
{
    public class MyDictionary : Dictionary<int, UniversityStudent>
    {
        public delegate void DictionaryHandler(int id, UniversityStudent student);

        public event DictionaryHandler OnAdd;

        public event DictionaryHandler OnRemove;
        
        public new void Add(int id, UniversityStudent student)
        {
            base.Add(id, student);
            OnAdd?.Invoke(id, student);
        }

        public new void Remove(int id)
        {
            var student = this[id];
            base.Remove(id);
            OnRemove?.Invoke(id, student);
        }
        
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
            if (dictionary.Count == 0)
                return dictionary;
            
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