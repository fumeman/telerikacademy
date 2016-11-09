using System;

class BobbyAvokadoto
{
    static void Main()
    {
        uint head, combN;
        if (!uint.TryParse(Console.ReadLine(), out head))
        {
            head = 0;
        }
        if (!uint.TryParse(Console.ReadLine(), out combN))
        {
            combN = 0;
        }

        uint max = 0, comb, number = 0;
        for (uint i = 0; i < combN; i++)
        {
            comb = uint.Parse(Console.ReadLine());
            
            if ((head & comb) == 0)
            {
                //valid
                uint tmp = comb, counter = 0;
                int bites = (Convert.ToString(comb, 2)).Length;
                for (uint j = 1; j <= bites ; j++)
                {
                    counter += (tmp & 1);
                    tmp = tmp >> 1;
                }
                if (counter > max)
                {
                    max = counter;
                    number = comb;
                }
            }
        }
        Console.WriteLine(number);
    }
}
