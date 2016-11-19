using System;

class FormattingNumbers
{
    static void Main()
    {
        bool condition;
        int a;
        double b, c;
        do
        {
            condition = false;
            a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 500) condition = true;
        } while (condition);
        b = Double.Parse(Console.ReadLine());
        c = Double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}", a, Convert.ToString(a,2).PadLeft(10, '0'), b, c);
    }
}
