using System;

class FindSumInArray
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

        int sum;
        if (!int.TryParse(Console.ReadLine(), out sum))
        {
            throw new Exception("Invalid Input! #1");
        }

        int positionStart = 0, positionEnd = 0, k = 0;
        bool flag = false;
        while (!flag && k < arr.Length)
        {
            long tmpSum = 0;
            for (int j = k; j < arr.Length; j++)
            {
                tmpSum += arr[j];
                if (sum < tmpSum)
                {
                    break;
                }
                else if (sum == tmpSum)
                {
                    positionStart = k;
                    positionEnd = j;
                    flag = true;
                    break;
                }
            }
            k++;
        }

        for (int i = positionStart; i <= positionEnd; i++)
        {
            if (i == positionEnd)
            {
                Console.WriteLine(arr[i]);
            }
            else 
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
        Console.WriteLine();
    }
}

