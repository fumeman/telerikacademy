using System;
using System.Text;

namespace ReplaceTags
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
                end = text.IndexOf("<a href=\"", start);
                if (end < 0)
                {
                    end = text.Length;
                    newText.Append(text.Substring(start, end - start));
                    break;
                }
                newText.Append(text.Substring(start, end - start));
                start = end + 9;
                end = text.IndexOf("\">", start);

                int end2 = text.IndexOf("</a>", end + 2);
                newText.Append("[");
                newText.Append(text.Substring(end + 2, end2 - end - 2).Trim());
                newText.Append("](");
                newText.Append(text.Substring(start, end - start).Trim());
                newText.Append(")");
                start = end2 + 4;
            }
            Console.WriteLine(newText);
        }
    }
}
