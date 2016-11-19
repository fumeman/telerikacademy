using System;


class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] strarr = str.Split(',');
        int[] arr = new int[strarr.Length];
        for (int i = 0; i < strarr.Length; i++)
        {
            arr[i] = int.Parse(strarr[i]);
        }
        permute(arr, 0, arr.Length);
    }

    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void permute(int[] arr, int start, int end)
    {
        if (start == end)
        {
            //Console.Write("{0} ", ++Globals.br);
            for (int k = 0; k < arr.Length; k++)
            {
                if (k == arr.Length - 1)
                {
                    Console.WriteLine("{0} {1}",arr[k], '}');
                }
                else if(k == 0)
                {
                    Console.Write("{0} {1}, ",'{', arr[k]);
                }
                else
                {
                    Console.Write("{0}, ", arr[k]);
                }
            }
            return;
        }

        permute(arr, start + 1, end);
        int i;
        for (i = start + 1; i < end; i++)
        {
            if (arr[start] == arr[i])
                continue;
            swap(arr, start, i);
            permute(arr, start + 1, end);
            swap(arr, start, i);
        }
        return;
    }

    //public static class Globals
    //{
    //    public static int br = 0;
    //}
}

