using System;

class RemoveElements
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input! #1");
            }
        } while (1 > numN || numN > 1024);

        int[] arr = new int[numN];

        for (int i = 0; i < numN; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                throw new Exception("Invalid Input! #1");
            }
        }
        int[] tmp1 = new int[numN];
        int[] rmp2 = new int[numN + 1];


        int max = 0;
        for (int i = 0; i < numN; i++)
        {
            int lo = 1;
            int hi = max;
            while (lo <= hi)
            {
                int mid = ((lo + hi) / 2);
                if (arr[rmp2[mid]] <= arr[i])
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }

            int len = lo;
            tmp1[i] = rmp2[len - 1];
            rmp2[len] = i;

            if (len > max)
            {
                max = len;
            }
        }

        //// Reconstruct the longest increasing subsequence
        //Console.WriteLine();
        //int[] S = new int[max];
        //int k = tmp2[max];
        //for (int i = max - 1; i >= 0; i--)
        //{
        //    S[i] = arr[k];
        //    k = tmp1[k];
        //}
        //for (int i= 0; i<max; i++)
        //    Console.WriteLine(S[i]);
        //Console.WriteLine();
        Console.WriteLine(numN - max);
    }
}