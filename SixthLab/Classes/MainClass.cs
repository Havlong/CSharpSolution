using System;
using System.Runtime.InteropServices;

namespace SixthLab.Classes
{
    public class MainClass
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr handle, string text, string title, uint type);

        public void MakeToast(string title, string text)
        {
            MessageBox(IntPtr.Zero, text, title, uint.MinValue);
        }

        private static MainClass _instance;

        public static MainClass GetInstance()
        {
            return _instance ?? (_instance = new MainClass());
        }

        private MainClass()
        {
        }
        
        public Random Rnd = new Random();

        public Object Triple(Object number)
        {
            if (number is int)
            {
                return 3 * (int) number;
            }

            if (number is double)
            {
                return 3 * (double) number;
            }

            throw new NotANumberException("Expected int or double", number);
        }
    }
}