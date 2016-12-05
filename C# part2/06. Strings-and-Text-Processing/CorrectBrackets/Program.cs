using System;

namespace CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    counter++;
                }
                else if (str[i] == ')')
                {
                    counter--;
                    if (counter < 0)
                    {
                        break;
                    }
                }
            }
            string answer = (counter == 0) ? "Correct" : "Incorrect";
            Console.WriteLine(answer);
        }
    }
}
