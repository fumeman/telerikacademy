using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("i= {0}, d= {1}", i, d);
        d = 0; i = 0;
        Console.WriteLine("i= {0}, d= {1}", i, d);
    }
}
