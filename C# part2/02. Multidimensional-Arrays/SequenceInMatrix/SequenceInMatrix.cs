using System;

class SequenceInMatrix
{
    static void Main()
    {
        string[] tmp = Console.ReadLine().Split(' ');
        int numN = int.Parse(tmp[0]);
        int numM = int.Parse(tmp[1]);

        string[,] arr = new string[numN, numM];

        for (int i = 0; i < numN; i++)
        {
            tmp = Console.ReadLine().Split(' ');
            for (int j = 0; j < tmp.Length; j++)
            {
                arr[i, j] = tmp[j];
            }
        }

        int max = 1;

        //rows
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int counter = 1;
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] == arr[i, j + 1])
                {
                    max = Math.Max(++counter, max);
                }
                else counter = 1;
            }
        }
        //columns
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int counter = 1;
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                if (arr[i, j] == arr[i + 1, j])
                {
                    max = Math.Max(++counter, max);
                }
                else counter = 1;
            }
        }

        int choice = Math.Max(arr.GetLength(0), arr.GetLength(1));

        //down left trangle
        for (int i = 0; i < choice - 1; i++)
        {
            int row = i;
            int col = 0, counter = 1;
            while (row < arr.GetLength(0) - 1 && col < arr.GetLength(1) - 1)
            {
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    max = Math.Max(++counter, max);
                }
                else
                {
                    counter = 1;
                }
                row++;
                col++;
            }
        }

        //up right trangle
        for (int i = 1; i < choice - 1; i++)
        {
            int col = i;
            int row = 0, counter = 1;
            while (row < arr.GetLength(0) - 1 && col < arr.GetLength(1) - 1)
            {
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    max = Math.Max(++counter, max);
                }
                else
                {
                    counter = 1;
                }
                row++;
                col++;
            }
        }

        //down right trangle
        for (int i = 0; i < choice - 1; i++)
        {
            int row = i;
            int col = arr.GetLength(1) - 1, counter = 1;
            while (row < arr.GetLength(0) - 1 && col > 0)
            {
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    max = Math.Max(++counter, max);
                }
                else
                {
                    counter = 1;
                }
                row++;
                col--;
            }
        }

        //up left trangle
        for (int i = arr.GetLength(1) - 2; i > 0; i--)
        {
            int col = i;
            int row = 0, counter = 1;
            while (row < arr.GetLength(0) - 1 && col > 0)
            {
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    max = Math.Max(++counter, max);
                }
                else
                {
                    counter = 1;
                }
                row++;
                col--;
            }
        }
        Console.WriteLine(max);
    }
}
