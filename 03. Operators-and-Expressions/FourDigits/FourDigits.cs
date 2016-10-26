using System;

class FourDigits
{
    static void Main()
    {
        int a, b, c, d;
        a = Console.Read() - '0';
        b = Console.Read() - '0';
        c = Console.Read() - '0';
        d = Console.Read() - '0';
        Console.WriteLine(a+b+c+d);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
    }
}
