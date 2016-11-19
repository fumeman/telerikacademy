using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        byte numN;
        do
        {
            Byte.TryParse(Console.ReadLine(), out numN);
        } while (numN < 0 || numN > 100);

        BigInteger factorial2N = 1, factorialNPlus = 1, factorialN = 1;
        for (byte b = 1; b <= (numN *2); b++)
        {
            factorial2N *= b;
            if ( b == numN)
            {
                factorialN = factorial2N;
            }
            if (b == numN + 1)
            {
                factorialNPlus = factorial2N;
            }
        }
        Console.WriteLine(factorial2N / (factorialNPlus * factorialN));
    }
}
