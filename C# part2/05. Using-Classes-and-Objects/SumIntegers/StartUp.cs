using System;

namespace SumIntegers
{
    class StartUp
    {
        static void Main()
        {
            string values = Console.ReadLine();

            int sum = 0;
            string next = String.Empty;
            foreach (var ch in values)
            {
                if (ch != 0x20)
                {
                    next += ch;
                }
                else
                {
                    sum += int.Parse(next);
                    next = "";
                }
            }
            if (!String.IsNullOrEmpty(next))
            {
                sum += int.Parse(next);
            }
            Console.WriteLine(sum);
        }
    }
}
