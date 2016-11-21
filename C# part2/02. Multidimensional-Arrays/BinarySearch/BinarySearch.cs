using System;

class BinarySearch
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
        }
        int numK = int.Parse(Console.ReadLine());

        int result = Array.BinarySearch(arr, numK);

        string tmp = (result < 0) ? "not found" : "position "+result.ToString();
        Console.WriteLine(tmp);
    }
}
