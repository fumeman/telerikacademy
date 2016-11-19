using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int numN;
        do
        {
            if (!Int32.TryParse(Console.ReadLine(), out numN))
            {
                numN = 0;
            }
        } while (numN < 4 || numN > 50);

        string input = Console.ReadLine();
        string[] nums = input.Split(' ');
        long counter = 1, odd = 1, even = 1;
        foreach (string num in nums)
        {
            long numB;
            if (Int64.TryParse(num, out numB))
            {
                if (counter % 2 == 0)
                {
                    even *= numB;
                }
                else
                {
                    odd *= numB;
                }

                counter++;
                if (counter > numN)
                {
                    break;
                }
            }
        }
        if (even == odd)
        {
            Console.WriteLine("yes {0}", odd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", odd, even);
        }
    }
}
