using System;
using System.Text;

namespace ForbiddenWords
{
    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] forbiddens = Console.ReadLine().Split(' ');

            StringBuilder newText = new StringBuilder();

            foreach (string word in forbiddens)
            {
                int end = 0;
                int start = 0;
                while (end < text.Length)
                {
                    end = text.IndexOf(word, start);
                    if (end < 0)
                    {
                        newText.Append(text.Substring(start, text.Length - start));
                        break;
                    }
                    else
                    {
                        newText.Append(text.Substring(start, end - start));
                        start = end + word.Length;
                        newText.Append('*', word.Length);
                        end = start;
                    }
                }
                text = newText.ToString();
                newText.Clear();
            }
            Console.WriteLine(text);
        }
    }
}
