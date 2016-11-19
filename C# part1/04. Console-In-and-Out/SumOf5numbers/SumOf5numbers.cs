using System;

class SumOf5numbers
{
    static void Main()
    {
        int num1, num2, num3, num4, num5;
        bool condition;
        do
        {
            condition = false;
     
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            if (num1 < -1000 || num2 < -1000 || num3 < -1000 || num4 < -1000 || num5 < -1000 || num1 > 1000 || num2 > 1000 || num3 > 1000 || num4 > 1000 || num5 > 1000) condition = true;
        } while (condition);
        Console.WriteLine(num1 + num2 + num3 + num4 + num5);
    }
}
