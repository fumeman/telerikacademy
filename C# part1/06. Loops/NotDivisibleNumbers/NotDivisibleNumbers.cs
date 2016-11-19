using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        uint numN;
        string input = Console.ReadLine();
        if (!UInt32.TryParse(input, out numN))
        {
            numN = 0;
        }

        bool flag = false;
        if (numN > 1 && numN < 1500)
        {
            for (uint i = 1; i <= numN; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    if (flag)
                    {
                        Console.Write(" {0}", i);             
                    }
                    else
                    {
                        Console.Write(i);
                        flag = true;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
