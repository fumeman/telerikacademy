using System;
using System.Text;

namespace ParseTags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            int start = 0;
            int end = 0;

            while (end < text.Length)
            {
                end = text.IndexOf("<upcase>", start);
                if (end < 0)
                {
                    end = text.Length;
                    newText.Append(text.Substring(start, end - start));
                    break;
                }
                newText.Append(text.Substring(start, end - start));
                start = end + 8;
                end = text.IndexOf("</upcase>", start);
                if (end < 0)
                {
                    end = text.Length;
                    newText.Append(text.Substring(start, end - start));
                    break;
                }
                newText.Append(text.Substring(start, end - start).ToUpper());
                start = end + 9;
            }
            Console.WriteLine(newText);
        }
    }
}
