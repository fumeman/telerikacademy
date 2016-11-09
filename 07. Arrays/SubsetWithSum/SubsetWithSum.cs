using System;
using System.Collections.Generic;

class SubsetWithSum
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strarr = str.Split(',');
        int[] arr = new int[strarr.Length];
        for (int i = 0; i < strarr.Length; i++)
        {
            arr[i] = int.Parse(strarr[i]);
        }

        int sum;
        if (!int.TryParse(Console.ReadLine(), out sum))
        {
            throw new Exception("Invalid Input! #1");
        }


        if (isSubsetSum(arr, arr.Length, sum))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static bool isSubsetSum(int[] set, int len, int sum)
    {

        bool[,] subset = new bool[sum + 1, len + 1];


        for (int i = 0; i <= len; i++)
        {
            subset[0, i] = true;
        }

        for (int i = 1; i <= sum; i++)
        {
            subset[i, 0] = false;
        }


        for (int i = 1; i <= sum; i++)
        {
            for (int j = 1; j <= len; j++)
            {
                subset[i, j] = subset[i, j - 1];
                if (i >= set[j - 1])
                    subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];
            }
        }
        for (int i = 0; i <= sum; i++)
        {
            for (int j = 0; j <= len; j++)
                Console.Write("{0, -10}", subset[i, j]);
            Console.WriteLine(); ;
        }
        return subset[sum, len];
    }
}
