using System;

namespace SubStringInText
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            string[] str = text.Split(new string[] { pattern }, StringSplitOptions.None);
            Console.WriteLine(str.Length - 1);
        }
    }
}
