using System;
using System.Text;

namespace ReverseString
{
    class StartUp
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder reversedText = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedText.Append(str[i]);
            }

            Console.WriteLine(reversedText);
        }
    }
}
