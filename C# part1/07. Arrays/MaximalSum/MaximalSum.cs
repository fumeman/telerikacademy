using System;

class MaximalSum
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                numN = 0;
            }
        } while (1 > numN || numN > 1024);

        double[] arr = new double[numN];
        for (int i = 0; i < numN; i++)
        {
            if (!double.TryParse(Console.ReadLine(), out arr[i]))
            {
                arr[i] = 0;
            }

        }

        double max = 0;
        for (int i = 0; i < numN; i++)
        {
            double sum = 0;
            for (int j = i; j < numN; j++)
            {
                sum += arr[j];
                if (sum > max)
                {
                    max = sum;
                }
            }
        }
        Console.WriteLine(max);
    }
}
