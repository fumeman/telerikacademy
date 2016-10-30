using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        byte numN, numK;
        do
        {
            Byte.TryParse(Console.ReadLine(), out numN);
            Byte.TryParse(Console.ReadLine(), out numK);
        } while (numK <= 1 || numK >= numN || numN >= 100);

        BigInteger factorialN = 1, factorialK = 1, faktorialNK = 1;
        for (byte b = 1; b <= numN; b++)
        {
            factorialN *= b;
            if (b == numN - numK)
            {
                faktorialNK = factorialN;
            }
            if (b == numK)
            {
                factorialK = factorialN;
            }
        }
        Console.WriteLine(factorialN / (factorialK * faktorialNK));
    }
}
