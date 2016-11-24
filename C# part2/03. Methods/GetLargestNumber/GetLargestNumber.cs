using System;

class GetLargestNumber
{
    static int GetMax(int[] arr)
    {
        int result = -1;
        if (arr[0] >= arr[1] && arr[0] >= arr[2])
        {
            result = arr[0];   
        }
        else if (arr[1] >= arr[0] && arr[1] >= arr[2])
        {
            result = arr[1];
        }
        else if (arr[2] >= arr[0] && arr[2] >= arr[1])
        {
            result = arr[2];
        }
        return result;
    }

    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        
        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
        }

        Console.WriteLine(GetMax(arr));
    }
}
