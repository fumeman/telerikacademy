using System;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        byte p, q, k;
        bool condition;
        do
        {
            condition = false;
            p = byte.Parse(Console.ReadLine());
            q = byte.Parse(Console.ReadLine());
            k = byte.Parse(Console.ReadLine());
            if (p < 0 || q < 0) condition = true;
            if ((p + k - 1 >= 32) || (q + k - 1 >= 32)) condition = true;
        }
        while (condition);
        uint mask1, mask2;
        mask1 = mask2 = 0;
        for (byte i = p; i < (k + p); i++) mask1 = mask1 | (Convert.ToUInt32(1) << i);
        for (byte i = q; i < (k + q); i++) mask2 = mask2 | (Convert.ToUInt32(1) << i);
        uint tmp1 = number & mask1;
        uint tmp2 = number & mask2;
        if (p < q)
        {
            tmp1 = tmp1 << (q - p);
            tmp2 = tmp2 >> (q - p);
        }
        else
        {
            tmp1 = tmp1 >> (p - q);
            tmp2 = tmp2 << (p - q);
        }
        number = number & ~mask1;
        number = number & ~mask2;
        number = (number | tmp1) | tmp2;
        Console.WriteLine(number);
    }
}
