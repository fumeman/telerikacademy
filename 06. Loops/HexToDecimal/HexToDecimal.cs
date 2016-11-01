using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToUpper();

        ulong num = 0;
        int len = input.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            double power = Math.Pow(16, (len - i - 1));

            int addNum;
            if (input[i] >= 'A' && input[i] <= 'F')
            {
                addNum = 0x37;  //ascii A-F
            }
            else if (input[i] >= '0' && input[i] <= '9')
            {
                addNum = 0x30;  //ascii 0-9
            }
            else
            {
                throw new Exception("Invalid input!!!");
            }

            num += (UInt64)(((char)input[i] - addNum) * power); // X * (16 ^ y) 
        }
        Console.WriteLine(num);
    }
}
