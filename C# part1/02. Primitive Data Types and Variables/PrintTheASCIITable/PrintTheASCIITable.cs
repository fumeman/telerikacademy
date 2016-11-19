using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (byte counter = 33; counter <= 126; counter++)
        {
            if (counter == 126)
                Console.Write("{0}\n", (char)counter);
            else
                Console.Write("{0} ", (char)counter);
        }
    }
}