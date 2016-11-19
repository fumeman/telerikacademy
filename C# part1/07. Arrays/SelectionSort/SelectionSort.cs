using System;

class SelectionSort
{
    private static int k;

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

        double[] arr1 = new double[numN];
        double[] arr2 = new double[numN];
        for (int i = 0; i < numN; i++)
        {
            if (!double.TryParse(Console.ReadLine(), out arr1[i]))
            {
                throw new Exception("Invalid Input");
            }
        }

        for (int i = 0; i < numN; i++)
        {
            double min = double.MaxValue;
            int tmp = 0;
            for (int j = 0; j < numN; j++)
            {
                if (arr1[j] < min)
                {
                    min = arr1[j];
                    tmp = j;
                }
            }
            arr2[i] = arr1[tmp];
            arr1[tmp] = double.MaxValue;
        }

        for (int i = 0; i < numN; i++)
            Console.WriteLine(arr2[i]);
    }
}
