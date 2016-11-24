using System;
using System.Numerics;

class BinToDecimal
{
    static BigInteger BinToDec(string bin)
    {
        BigInteger result = 0;

        foreach (char ch in bin)
        {
            result = result * 2 + ch - 48;
        }
        return result;
    }

    static void Main()
    {
        bool flag;
        string binNum;
        do
        {
            flag = false;
            binNum = Console.ReadLine();
            if (binNum == "")
            {
                flag = true;
            }
            foreach (char ch in binNum)
            {
                if (ch > 49 || ch < 48)
                {
                    flag = true;
                }
            }
        } while (flag);

        Console.WriteLine(BinToDec(binNum));
    }
}
