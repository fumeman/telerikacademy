using System;

class SortingArray
{
    static int[] SortArray(int[] arr)
    {
        int[] SortedArr = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int index = FindBiggest(arr);
            SortedArr[i] = arr[index];
            arr[index] = int.MinValue;
        }

        return SortedArr;
    }

    static int FindBiggest(int[] arr)
    {
        int max = int.MinValue;
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                index = i;
            }
        }

        return index;
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
        } while (1 > numN || numN > 1024);

        string[] str = Console.ReadLine().Split(' ');

        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
        }

        foreach (int number in SortArray(arr))
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
