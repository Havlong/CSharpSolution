using System;
using System.Collections.Generic;
using System.Linq;

namespace EighthLab.Classes
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
        
        private Random rnd = new Random();

        public List<MyDictionary> ListOfDictionaries = new List<MyDictionary>();

        public void GenerateStudentsCollection()
        {
            int n = rnd.Next(50);
            
            MyDictionary dict = new MyDictionary();

            for (int i = 0; i < n; i++)
            {
                dict++;
            }
            
            ListOfDictionaries.Add(dict);
        }

        public int GetCountOfCollectionsWithId(int id)
        {
            return ListOfDictionaries.Count(dictionary => dictionary.ContainsKey(id));
        }

        public MyDictionary FindMaxDictWithId(int id)
        {
            return ListOfDictionaries.Where(dictionary => dictionary.ContainsKey(id)).Max();
        }
    }
}