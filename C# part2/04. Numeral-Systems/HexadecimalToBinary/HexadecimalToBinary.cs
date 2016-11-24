using System;

class HexadecimalToBinary
{
    static string HexToBin(string hex)
    {
        string result = "";

        char[] arrHex = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        string[] arrBin = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };

        foreach (var ch in hex)
        {
            for (int i = 0; i < arrHex.Length; i++)
            {
                if (ch == arrHex[i])
                {
                    result += arrBin[i];
                }
            }
        }

        result = result.TrimStart('0');
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

        Console.WriteLine(HexToBin(binNum));
    }
}
