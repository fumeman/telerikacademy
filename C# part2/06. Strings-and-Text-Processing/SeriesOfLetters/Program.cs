using System;
using System.Text;

namespace SeriesOfLetters
{
    class Program
    {
        static StringBuilder result = new StringBuilder();

        static StringBuilder ReplaceSeries(string str)
        {
            if (str.Length > 0)
            {
                result.Append(str[0]);
                ReplaceSeries(str.TrimStart(str[0]));
            }
            
            return result;
        }

        static void Main()
        {
            string text = Console.ReadLine();

            Console.WriteLine(ReplaceSeries(text));
        }
    }
}
