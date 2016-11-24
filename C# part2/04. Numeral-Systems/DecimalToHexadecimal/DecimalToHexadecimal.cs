using System;
using System.Numerics;

class DecimalToHexadecimal
{
    static string DecToHex(BigInteger number)
    {
        string result = "";

        byte rest;
        do
        {
            rest = (byte)(number % 16);
            number = number / 16;

            rest += 0x30;
            if (rest > 0x39)
            {
                rest += 7;
            }
            result = ((char)rest).ToString() + result;

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
