using System;

class PrimeCheck
{
    static void Main()
    {
        int N;
        bool condition;
        N = int.Parse(Console.ReadLine());
        condition = false;
        if (N > 1)
        {
            condition = true;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) condition = false;
            }
        }
        if (condition) Console.WriteLine("true");
        else Console.WriteLine("false");
    }
}
