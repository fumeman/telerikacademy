using System;

class ComparingFloats
{
    static void Main()
    {
        double v1, v2, tmp;
        Console.Write("Enter First Value: ");
        v1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Second Value: ");
        v2 = double.Parse(Console.ReadLine());
        tmp = v1 - v2;
        if (tmp < 0) { tmp = v2 - v1; }
        if (tmp <= 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
