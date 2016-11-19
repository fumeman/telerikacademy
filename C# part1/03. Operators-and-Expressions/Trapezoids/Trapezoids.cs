using System;

class Trapezoids
{
    static void Main()
    {
        double a, b, h;

        a = Double.Parse(Console.ReadLine());
        b = Double.Parse(Console.ReadLine());
        h = Double.Parse(Console.ReadLine());
        Console.WriteLine(((a+b)*h/2).ToString("0.0000000"));
    }
}

