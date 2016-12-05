using System;
using System.Collections.Generic;

namespace ExtractE_mails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            List<string> emails = new List<string>();

            int index = 0;
            int indexStart = 0;
            int indexEnd = 0;
            while (index < text.Length)
            {
                index = text.IndexOf("@", index);
                if (index < 0)
                {
                    break;
                }
                indexEnd = index;
                indexStart = index;

                do
                {
                    indexStart--;
                } while (indexStart >= 0 && (Char.IsLetter(text[indexStart]) || text[indexStart] == '.' || char.IsDigit(text[indexStart])));
                indexStart++;

                do
                {
                    indexEnd++;
                } while (indexEnd < text.Length && (Char.IsLetter(text[indexEnd]) || text[indexEnd] == '.' || char.IsDigit(text[indexEnd])));

                if (indexStart < index && index < indexEnd - 1)
                {
                    emails.Add(text.Substring(indexStart, indexEnd - indexStart));
                }

                index = indexEnd + 1;
            }

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
