using System;

class AllocateArray
{
    static void Main()
    {
        uint input;
        if (!uint.TryParse(Console.ReadLine(), out input))
        {
            input = 0;
        }

        int[] arr = new int[input];
        for (int i = 0; i < input; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine(arr[i]);
        }

    }
}
