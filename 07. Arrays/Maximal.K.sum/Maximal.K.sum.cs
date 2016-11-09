using System;

class MaximalKsum
{
    static void Main()
    {
        int numN, numK;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                numN = 0;
            }
            if (!int.TryParse(Console.ReadLine(), out numK))
            {
                numK = 0;
            }

        } while (1 > numN || numK > numN || numN > 1024);

        double[] arr = new double[numN];
        for (int i = 0; i < numN; i++)
        {
            if (!double.TryParse(Console.ReadLine(), out arr[i]))
            {
                throw new Exception("Invalid input");
            }
        }

        int len = arr.Length, newLen;
        while (len != 0)
        {
            newLen = 0;
            for (int i = 1; i <= len - 1; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    double tmp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = tmp;
                    newLen = i;
                }
            }
            len = newLen;
        }

        double sum = 0;
        for (int i = numN - 1; i >= numN - numK; i--)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
