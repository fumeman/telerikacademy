using System;

class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        ulong tmp = 1;
        tmp = tmp << P;
        if (v == 0)
        {
            tmp = tmp ^ ulong.MaxValue;
            N = N & tmp;
        }
        else N = N | tmp;
        Console.WriteLine(N);
    }
}
