using System;

class LargerThanNeighbours
{
    static int Larger(int[] arr)
    {
        int result = 0;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
            {
                result++;
                i++;
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

        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
        }

        Console.WriteLine(Larger(arr));
    }
}
