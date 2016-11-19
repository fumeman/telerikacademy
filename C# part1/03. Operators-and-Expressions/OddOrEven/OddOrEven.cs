using System;

class OddOrEven
{
    static void Main()
    {
        int variable;
        variable = int.Parse(Console.ReadLine());
        if ((variable & 1) == 0)
        {
            Console.WriteLine("even {0}", variable);
        }
        else
        {
            Console.WriteLine("odd {0}", variable);
        };
    }
}