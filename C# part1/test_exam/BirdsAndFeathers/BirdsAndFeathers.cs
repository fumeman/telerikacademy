using System;

class BirdsAndFeathers
{
    static void Main()
    {
        uint birds, feathers;
        if (!uint.TryParse(Console.ReadLine(), out birds))
        {
            birds = 0;
        }
        if (!uint.TryParse(Console.ReadLine(), out feathers))
        {
            feathers = 0;
        }

        double average = (double)feathers / (double)birds;
        if ((birds % 2) == 0)
        {
            Console.WriteLine("{0:f4}", average * 123123123123);
        }
        else
        {
            Console.WriteLine("{0:f4}", average / 317);
        }
    }
}
