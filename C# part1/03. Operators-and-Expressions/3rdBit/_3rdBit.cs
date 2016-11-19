using System;

class _3rdBit
{
    static void Main()
    {
        uint number;
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine((number >> 3) & 1); 
    }
}
