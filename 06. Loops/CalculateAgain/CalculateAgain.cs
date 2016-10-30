using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        byte numN, numK;
        do
        {
            Byte.TryParse(Console.ReadLine(), out numN);
            Byte.TryParse(Console.ReadLine(), out numK);
        } while (numK <= 1 || numK >= numN || numN >= 100);

        BigInteger factorialN = 1, factorialK = 1;
        for (byte b =1; b <= numN; b++)
        {
            factorialN *= b;
        }
        for (byte b = 1; b <= numK; b++)
        {
            factorialK *= b;
        }
        Console.WriteLine(factorialN / factorialK);
    }
}
