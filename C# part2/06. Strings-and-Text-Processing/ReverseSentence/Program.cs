using System;

namespace ReverseSentence
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Substring(0, text.Length - 2).Split(' ');

            for (int i = words.Length - 1; i > 0; i--)
            {
                Console.Write("{0} ",words[i]);
            }
            Console.WriteLine("{0}{1}", words[0],text[text.Length-1]);
        }
    }
}
