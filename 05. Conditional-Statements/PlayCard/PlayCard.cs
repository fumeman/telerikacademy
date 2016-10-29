using System;

class PlayCard
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string input = Console.ReadLine();
        bool flag = false;

        foreach (string card in cards)
        {
            if (input == card)
            {
                flag = true;
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("yes {0}", input);
        }
        else
        {
            Console.WriteLine("no {0}", input);
        }
    }
}
