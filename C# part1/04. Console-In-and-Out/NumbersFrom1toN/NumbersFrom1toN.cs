using System;

class NumbersFrom1toN
{
    static void Main()
    {
        int N;
        bool condition;
        do
        {
            condition = false;
            N = int.Parse(Console.ReadLine());
            if (N < 1 || N > 999) condition = true;
        } while (condition);
        for (int i = 1; i <= N; i++) Console.WriteLine(i);
    }
}
