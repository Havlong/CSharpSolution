using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FifthLab.Classes
{
    public static class SomeUsefulMethods
    {
        public static double ReturnAndCheckMark(string s)
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
        
        public static bool IsLetterEntered(string s)
        {
            Regex regex = new Regex(@"[a-zа-яA-ZА-Я]+");
            MatchCollection matches = regex.Matches(s);
            return matches.Count != 0;
        }
    }
}