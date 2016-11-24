using System;
using System.Numerics;

class HexadecimalToDecimal
{
    static BigInteger HexToDec(string hex)
    {
        BigInteger result = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            char ch = hex[i];
            if (ch > 0x40)
            {
                result = result * 16 + ch - 0x37;
            }
            else
            {
                result = result * 16 + ch - 0x30;
            }
            
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
                if ((ch > 0x39 || ch < 0x30) && (ch > 0x46 || ch < 0x41))
                {
                    flag = true;
                }
            }
        } while (flag);

        Console.WriteLine(HexToDec(binNum));
    }
}
