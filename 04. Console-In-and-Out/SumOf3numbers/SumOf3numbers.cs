using System;

class SumOf3numbers
{
    static void Main()
    {
        float a, b, c;
        bool condition;
        do
        {
            condition = false;
            a = Single.Parse(Console.ReadLine());
            b = Single.Parse(Console.ReadLine());
            c = Single.Parse(Console.ReadLine());
            if (a < -1000 || b < -1000 || c < -1000 || a > 1000 || b > 1000 || c > 1000) condition = true;
        } while (condition);
        Console.WriteLine(a + b + c);
    }
}
