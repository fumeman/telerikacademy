using System;

class FrequentNumber
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                numN = 0;
            }
        } while (1 > numN || numN > 1024);

        int[] arr = new int[numN];
        for (int i = 0; i < numN; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                numN = 0;
            }
        }

        int max = 0, position = 0;
        for (int i = 0; i < numN; i++)
        {
            int counter = 0;
            for (int j = 0; j < numN; j++)
            {
                if (arr[j] == arr[i])
                {
                    counter++;
                    if (counter > max)
                    {
                        max = counter;
                        position = i;
                    }
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", arr[position], max);
    }
}

