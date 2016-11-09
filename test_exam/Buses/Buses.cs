using System;

class Buses
{
    static void Main()
    {
        int buses;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out buses))
            {
                buses = 1;
            }
        } while (buses < 1 && buses > 1000);

        uint[] speed = new uint[buses];

        for (int i = 0; i < buses; i++)
        {
            if (!uint.TryParse(Console.ReadLine(), out speed[i]))
            {
                speed[i] = 1;
            }
        }

        int groups = 1;
        uint formBus = speed[0];
        for (int i = 1; i < buses; i++)
        {
            if (speed[i] <= formBus)
            {
                groups++;
                formBus = speed[i];
            } 
        }

        Console.WriteLine(groups);
    }
}
