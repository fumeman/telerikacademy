using System;
using System.Linq;
using System.Text;

namespace GoshoCode
{
    class Program
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            int numN = int.Parse(Console.ReadLine());
            StringBuilder fullText = new StringBuilder();
            string[] sentences = new string[100];
            for (int i = 0; i < numN; i++)
            {
                fullText.Append(Console.ReadLine());
                fullText.Append(' ');
            }

            int start = 0, end = 0, counter = 0;
            for (int i = 0; i < fullText.Length; i++)
            {
                if (Char.IsUpper(fullText[i]))
                {
                    start = i;
                }
                else if (fullText[i] == '.' || fullText[i] == '!')
                {
                    end = i;
                    sentences[counter++] = fullText.ToString().Substring(start, end - start + 1);
                }

            }

            int index = 0;
            string needed = String.Empty;
            for (int i = 0; i < counter; i++)
            {
                index = sentences[i].IndexOf(sentence);
                if (index != -1)
                {
                    if (sentences[i][sentences[i].Length -1] == '.')
                    {
                        needed = sentences[i].Substring(index+sentence.Length, sentences[i].Length - index - sentence.Length);
                        break;
                    }
                    else if (sentences[i][sentences[i].Length - 1] == '!')
                    {
                        needed = sentences[i].Substring(0, index);
                        break;
                    }
                }
            }

            int sum = 0;
            foreach (var ch in needed)
            {
                if (ch != 0x20 && ch != '.' && ch != '!')
                {

                    sum += ch * sentence.Length;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
