using System;

class QuickSort
{
    static public void sorting(int arrStart, int arrEnd, long[] arr)
    {
        long pivot = 0;
        if (arrStart < arrEnd)
        {
            pivot = arr[arrEnd];
            int begin = arrStart;
            for (int i = arrStart; i < arrEnd; i++)
            {
                if (arr[i] <= pivot)
                {
                    long temp = arr[begin];
                    arr[begin] = arr[i];
                    arr[i] = temp;
                    begin++;
                }
            }
            long tmp = arr[begin];
            arr[begin] = arr[arrEnd];
            arr[arrEnd] = tmp;
            sorting(arrStart, --begin, arr);
            sorting(++begin, arrEnd, arr);
        }
    }

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

        long[] arr = new long[numN];

        for (int i = 0; i < numN; i++)
        {
            if (!long.TryParse(Console.ReadLine(), out arr[i]))
            {
                throw new Exception("Invalid Input! #2");
            }

        }
        sorting(0, numN - 1, arr);
        for (int i = 0; i < numN; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}