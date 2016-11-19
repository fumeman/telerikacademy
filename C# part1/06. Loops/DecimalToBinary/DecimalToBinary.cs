using System;

class DecimalToBinary
{
    static void Main()
    {
        uint num;
        bool flag;
        do
        {
            flag = (UInt32.TryParse(Console.ReadLine(), out num));
        } while (!flag);

        string binary = null;

        if (num == 0)
        {
            binary = "0";
        }
        else
        {
            while (num > 0)
            {
                char ch = (char)(num % 2 + 0x30);
                binary = ch + binary;
                num = num / 2;
            }
        }
        Console.WriteLine(binary);
    }
}
