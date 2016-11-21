using System;

class SortByStringLength
{
    static public void sorting(int arrStart, int arrEnd, int[,] arr)
    {
        long pivot = 0;
        if (arrStart < arrEnd)
        {
            pivot = arr[0, arrEnd];
            int begin = arrStart;
            int temp1, temp2;
            for (int i = arrStart; i < arrEnd; i++)
            {
                if (arr[0, i] <= pivot)
                {
                    temp1 = arr[0, begin];
                    temp2 = arr[1, begin];
                    arr[0, begin] = arr[0, i];
                    arr[1, begin] = arr[1, i];
                    arr[0, i] = temp1;
                    arr[1, i] = temp2;
                    begin++;
                }
            }
            temp1 = arr[0, begin];
            temp2 = arr[1, begin];
            arr[0, begin] = arr[0, arrEnd];
            arr[1, begin] = arr[1, arrEnd];
            arr[0, arrEnd] = temp1;
            arr[1, arrEnd] = temp2;
            sorting(arrStart, --begin, arr);
            sorting(++begin, arrEnd, arr);
        }
    }

    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        int[,] arr = new int[2, str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            arr[0, i] = str[i].Length;
        }

        for (int i = 0; i < str.Length; i++)
        {
            arr[1, i] = i;
        }

        sorting(0, str.Length - 1, arr);
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[arr[1,i]]);
        }
    }
}
