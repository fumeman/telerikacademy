using System;

class DecimalToHex
{
    static void Main()
    {
        long num;
        bool flag;
        do
        {
            flag = (Int64.TryParse(Console.ReadLine(), out num));
        } while (!flag);

        string hex = null;

        if (num == 0)
        {
            hex = "0";
        }
        else
        {
            while (num > 0)
            {
                byte rest = (byte)(num % 16); 
                if (rest > 9)
                {
                    rest += 0x37; //ascii code A-F
                } 
                else
                {
                    rest += 0x30; //ascii code 0-9
                }
                char ch = (char)rest;
                hex = ch + hex;
                num = num / 16;
            }
        }
        Console.WriteLine(hex);
    }
}
