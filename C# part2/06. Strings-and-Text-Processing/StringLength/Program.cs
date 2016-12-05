using System;
using System.Text;

namespace StringLength
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder newStr = new StringBuilder(str);
            Console.WriteLine(newStr.Append('*', 20 - str.Length));
        }
    }
}
