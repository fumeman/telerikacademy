using System;

class NumberOfPages
{
    static void Main()
    {
        uint digits;
        do
        {
            if (!uint.TryParse(Console.ReadLine(), out digits))
            {
                digits = 0;
            }
        } while (digits <= 1 && digits >= 1000000);

        uint pages = 0, counter = 0;
        while (counter < digits)
        {
            pages++;
            int len = pages.ToString().Length;
            counter += (uint)len;
        }
        Console.WriteLine(pages);
    }
}
