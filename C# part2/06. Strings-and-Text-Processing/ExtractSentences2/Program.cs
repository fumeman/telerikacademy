using System;
using System.Linq;

namespace ExtractSentences2
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentences = text.Split('.').Select(p => p.Trim() + '.').ToArray();

            int index;
            foreach (string sentence in sentences)
            {
                index = 0;
                while (index <= sentence.Length && index >= 0)
                {
                    index = sentence.IndexOf(word, index);
                    if (index >= 0)
                    {
                        if (index == 0 && !Char.IsLetter(sentence[index + word.Length]))
                        {
                            Console.Write("{0} ", sentence);
                            break;
                        }
                        else if (index == 0 && Char.IsLetter(sentence[index + word.Length]))
                        {
                            index++;
                            continue;
                        }
                        else if (!Char.IsLetter(sentence[index - 1]) && !Char.IsLetter(sentence[index + word.Length]))
                        {
                            Console.Write("{0} ", sentence);
                            break;
                        }
                        index++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
