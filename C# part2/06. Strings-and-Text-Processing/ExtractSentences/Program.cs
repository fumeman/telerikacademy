using System;
using System.Linq;

namespace ExtractSentences
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            char[] ch = text.Where(p => !char.IsLetter(p)).Distinct().ToArray();

            for (int j = 0; j < sentences.Length; j++)
            {
                string[] words = sentences[j].Split(ch, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == word)
                    {
                        Console.Write("{0}. ", sentences[j].Trim());
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
