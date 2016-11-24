using System;

class BinaryToHexadecimal
{
    static string BinToHex(string bin)
    {
        string result = "";

        char[] arrHex = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        string[] arrBin = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };

        string tmp = "";
        byte counter = 0;
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            tmp = bin[i] + tmp; ;
            if (++counter == 4)
            {
                for (int j = 0; j < arrBin.Length; j++)
                {
                    if (tmp == arrBin[j])
                    {
                        result = arrHex[j] + result;
                        break;
                    }
                }
                tmp = "";
                counter = 0;
            }
        }

        if (tmp != "")
        {
            for (int i = 0; i < arrBin.Length; i++)
            {
                if (tmp == arrBin[i].TrimStart('0'))
                {
                    result = arrHex[i] + result;
                    break;
                }
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
                if (ch > 49 || ch < 48)
                {
                    flag = true;
                }
            }
        } while (flag);

        Console.WriteLine(BinToHex(binNum));
    }
}
