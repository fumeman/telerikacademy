using System;
using System.Numerics;

class OneSystemToAnyOther
{
    static BigInteger SomeToDec(string hex, byte basis)
    {
        BigInteger result = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            char ch = hex[i];
            if (ch > 0x40)
            {
                result = result * basis + ch - 0x37;
            }
            else
            {
                result = result * basis + ch - 0x30;
            }

        }
        return result;
    }

    static string DecToSome(BigInteger num, byte basis)
    {
        string result = "";

        byte rest;
        do
        {
            rest = (byte)(num % basis);
            num = num / basis;

            rest += 0x30;
            if (rest > 0x39)
            {
                rest += 7;
            }
            result = ((char)rest).ToString() + result;

        } while (num > 0);

        return result;
    }

    static string SomeToOther(string num, byte baseFrom, byte baseTo)
    {
        BigInteger bigNum = SomeToDec(num, baseFrom);
        string result = DecToSome(bigNum, baseTo);

        return result;
    }

    static void Main()
    {
        byte baseFrom = byte.Parse(Console.ReadLine());
        string num = Console.ReadLine();
        byte baseTo = byte.Parse(Console.ReadLine());
        Console.WriteLine(SomeToOther(num, baseFrom, baseTo));
    }
}
