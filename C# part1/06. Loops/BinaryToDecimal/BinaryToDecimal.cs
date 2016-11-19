using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        ulong num = 0;
        int len = input.Length; 
        for (int i = len - 1; i >= 0; i--)
        {
            double power = Math.Pow(2, (len - i - 1));
            num += (UInt64)(((char)input[i] - 0x30) * power); // (0 or 1) * (2 ^ x) 
        }
        Console.WriteLine(num);
    }
}
