using System;

class ThirdDigit
{
    static void Main()
    {
        int N;
        N = int.Parse(Console.ReadLine());
        N /= 100;
        N %= 10;
        if (N == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", N);
        }
    }
}