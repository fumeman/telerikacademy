using System;

class BinaryShort
{
    static string DecToHex(int number)
    {
        string result = "";
        bool overflow = false;

        if (number < 0)
        {
            number += 0x8000;
            overflow = true;
        }

        byte rest;
        do
        {
            rest = (byte)(number % 2);
            number = number / 2;
            result = rest + result;
        } while (number > 0);

        if (overflow)
        {
            result = "1" + result.PadLeft(15, '0'); ;
        }
        else
        {
            result = result.PadLeft(16, '0');
        }

        return result;
    }

    static void Main()
    {
        int num;
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            throw new Exception("Invalid Input!!!");
        }

        Console.WriteLine(DecToHex(num));
    }
}
