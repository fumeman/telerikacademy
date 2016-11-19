using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint tmp1, tmp2, mask1, mask2;
        mask1 = 0x38;
        mask2 = mask1 << 21;
        tmp1 = (number & mask1) << 21;
        number = number & ~mask1;
        tmp2 = (number & mask2) >> 21;
        number = number & ~mask2;
        number = (number | tmp1) | tmp2;
        Console.WriteLine(number);
    }
}
