using System;

class AppearanceCount
{
    static int AppCount(int[] arr, int comparator)
    {
        int result = 0;

        foreach (int number in arr)
        {
            if (number == comparator)
            {
                result++;
            }
        }

        return result;
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
        int numX = int.Parse(Console.ReadLine());

        int[] arr = new int[numN];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
        }

        Console.WriteLine(AppCount(arr, numX));
    }
}
