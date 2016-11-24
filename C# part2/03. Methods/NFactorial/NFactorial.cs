using System;
using System.Numerics;


class NFactorial
{
    static BigInteger Factorial(int[] arr)
    {
        BigInteger result = 1;

        if (arr.Length > 1)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                result *= arr[i];
            }
        }

        return result;
    }

    static int[] CreateArray(int num)
    {
        int[] result = new int[num + 1];

        for (int i = 0; i <= num; i++)
        {
            result[i] = i;
        }

        return result;
    }

    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input!");
            }
        } while (0 > numN || numN > 100);

        Console.WriteLine(Factorial(CreateArray(numN)));
    }
}
