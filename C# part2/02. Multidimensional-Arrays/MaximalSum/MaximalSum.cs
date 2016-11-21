using System;

class MaximalSum
{
    static void Main()
    {
        string[] tmp = Console.ReadLine().Split(' ');
        int numN = int.Parse(tmp[0]);
        int numM = int.Parse(tmp[1]);

        int[,] arr = new int[numN, numM];

        for (int i = 0; i < numN; i++)
        {
            tmp = Console.ReadLine().Split(' ');
            for (int j = 0; j < tmp.Length; j++)
            {
                arr[i, j] = int.Parse(tmp[j]);
            }
        }

        long maxSum = long.MinValue;
        for (int row = 2; row < arr.GetLength(0); row++)
        {
            for (int col = 2; col < arr.GetLength(1); col++)
            {
                int sum = 0;
                for (int i = row - 2; i <= row; i++)
                {
                    for (int j = col - 2; j <= col; j++)
                    {
                        sum += arr[i, j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}
