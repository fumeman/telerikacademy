using System;

class Interval
{
    static void Main()
    {
        int N, M, counter = 0;
        string input;
        do
        {
            input = Console.ReadLine();
            bool result = int.TryParse(input, out N);
            if (!result) N = 0;
            input = Console.ReadLine();
            result = int.TryParse(input, out M);
            if (!result) M = 0;
        } while (N < 0 || N > M || M > 2000);
        for (int i = N + 1; i < M; i++)
        {
            if (i % 5 == 0) counter++;
        }
        Console.WriteLine(counter);
    }
}
