using System;
using System.Numerics;

class DecimalToBinary
{
    static string DecToHex(BigInteger number)
    {
        string result = "";

        byte rest;
        do
        {
            rest = (byte)(number % 2);
            number = number / 2;
            result = rest + result;
        } while (number > 0);

        return result;
    }

    static void Main()
    {
        BigInteger bigNum;
        do
        {
            if (!BigInteger.TryParse(Console.ReadLine(), out bigNum))
            {
                bigNum = 0;
            }
        } while (1 > bigNum || bigNum > (BigInteger)Math.Pow(10, 18));

        Console.WriteLine(DecToHex(bigNum));
    }
}
