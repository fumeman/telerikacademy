using System;

class LongSequence
{
    static void Main()
    {
        var a = 2;
        var b = -3;
        for (int i = 0; i <= 998; i += 2)
        {
            Console.WriteLine(a + i);
            Console.WriteLine(b - i);
        }
    }
}
