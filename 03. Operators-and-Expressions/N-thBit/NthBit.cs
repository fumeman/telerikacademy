using System;

class NthBit
{
    static void Main(string[] args)
    {
        ulong P;
        byte N;
        P = ulong.Parse(Console.ReadLine());
        N = byte.Parse(Console.ReadLine());
        Console.WriteLine((P >> N) & 1);
    }
}

