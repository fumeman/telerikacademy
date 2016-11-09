using System;

class CombinationsOfSet
{
    static void Main()
    {
        int numN, numK;
        if (!int.TryParse(Console.ReadLine(), out numN))
        {
            throw new Exception("Invalid Input! #1");
        }

        if (!int.TryParse(Console.ReadLine(), out numK))
        {
            throw new Exception("Invalid Input! #1");
        }

        int[] arr = new int[numN];
        for (int i = 0; i < numN; i++)
        {
            arr[i] = i + 1;
        }

        getCombination(arr, numN, numK);
    }

    // Get all combination using temprary array 'tmp[]'    
    static void getCombination(int[] arr, int n, int r)
    {
        int[] tmp = new int[r];
        combination(arr, n, r, 0, tmp, 0);
    }

    /* arr[]  ---> Input Array
       numN   ---> Size of input array
       numK   ---> Size of a combination to be printed
       index  ---> Current index in tmp[]
       tmp[] ---> Temporary array to store current combination
       i      ---> index of current element in arr[]     */
    static void combination(int[] arr, int n, int r, int index, int[] tmp, int i)
    {
        //Cobination is ready, do print
        if (index == r)
        {
            for (int j = 0; j < r; j++)
            {
                if (j == 0)
                {
                    Console.Write("{0}{1}, ", '{', tmp[j]);
                }
                else if (j == r - 1)
                {
                    Console.WriteLine("{0}{1}", tmp[j], '}');
                }
                else
                {
                    Console.Write("{0}, ", tmp[j]);
                }
            }
            return;
        }

        // When no more elements are there to put in data[]
        if (i >= n)
            return;

        // current is included, put next at next location
        tmp[index] = arr[i];
        combination(arr, n, r, index + 1, tmp, i + 1);

        // current is excluded, replace it with next (Note that
        // i+1 is passed, but index is not changed)
        combination(arr, n, r, index, tmp, i + 1);
    }
}
