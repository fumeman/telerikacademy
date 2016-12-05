using System;
using System.Numerics;

namespace BitShiftMatrix
{
    class StartUp
    {
        static void PrintArr(BigInteger[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int movs = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            string[] codes = str.Split(' ');

            BigInteger[,] arr = new BigInteger[rows, cols];

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = BigInteger.Pow(2, rows - i + j - 1);

                }
            }

            //PrintArr(arr);

            int posR = rows - 1;
            int posC = 0;

            int coeff = Math.Max(rows, cols);
            BigInteger sum = 0;

            foreach (var code in codes)
            {
                int cod = int.Parse(code);
                int row = cod / coeff;
                int col = cod % coeff;

                if (col < posC)
                {
                    while (col <= posC)
                    {
                        sum += arr[posR, posC];
                        arr[posR, posC] = 0;
                        posC--;
                    }
                    posC++;
                }
                else if (col > posC)
                {
                    while (col >= posC)
                    {
                        sum += arr[posR, posC];
                        arr[posR, posC] = 0;
                        posC++;
                    }
                    posC--;
                }

                if (row < posR)
                {
                    while (row <= posR)
                    {
                        sum += arr[posR, posC];
                        arr[posR, posC] = 0;
                        posR--;
                    }
                    posR++;
                }
                else if (row > posR)
                {
                    while (row >= posR)
                    {
                        sum += arr[posR, posC];
                        arr[posR, posC] = 0;
                        posR++;
                    }
                    posR--;
                }
                //PrintArr(arr);
                
            }

            Console.WriteLine(sum);
        }
    }
}
