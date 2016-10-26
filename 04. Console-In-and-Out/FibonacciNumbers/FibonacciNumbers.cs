using System;

class FibonacciNumbers
{
    static void Main()
    {
        int N; 
        ulong fibonacci0 = 0;
        ulong fibonacci1 = 1;
        do
        {
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out N);
        } while (N < 1 || N > 50);
        for (int i = 1; i <= N; i++)
        {
            if (i > 1)
            {
                Console.Write(", {0}", fibonacci1);
                ulong tmp = fibonacci1;
                fibonacci1 += fibonacci0;
                fibonacci0 = tmp;
            }
            else Console.Write("0");
        }
        Console.WriteLine();
    }
}
