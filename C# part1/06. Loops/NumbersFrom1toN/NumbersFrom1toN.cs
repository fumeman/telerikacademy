using System;

class NumbersFrom1toN
{
    static void Main()
    {
        uint numN;
        string input = Console.ReadLine();
        if (!UInt32.TryParse(input, out numN))
        {
            numN = 0;
        }
        for (uint i = 1; i <= numN; i++)
        {
            if (i < numN)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}