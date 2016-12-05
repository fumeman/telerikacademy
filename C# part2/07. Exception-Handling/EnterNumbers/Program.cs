using System;

namespace EnterNumbers
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {
            string[] stringArr = new string[10];

            for (int i = 0; i < 10; i++)
            {
                stringArr[i] = Console.ReadLine();
            }

            int[] arr = new int[12];
            arr[0] = start;
            arr[11] = end;

            for (int i = 1; i < 11; i++)
            {
                arr[i] = int.Parse(stringArr[i - 1]);
            }

            for (int i = 0; i < 11; i++)
            {
                if (arr[i]>=arr[i+1])
                {
                    throw new FormatException();
                }
            }


            for (int i = 0; i < 11; i++)
            {
                Console.Write($"{arr[i]} < ");
            }
            Console.WriteLine(arr[11]);
        }

        static void Main()
        {
            try
            {
                ReadNumber(1, 100);
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
