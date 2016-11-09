using System;

class PrimeNumbers
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input! #1");
            }
        } while (2 > numN || numN > 10000000);

        bool[] arr = new bool[numN + 1];
        for (int i = 2; i <= Math.Sqrt(numN); i++)
        {
            if (!arr[i])
            {
                for (int j = i * i; j <= numN; j += i)
                {
                    arr[j] = true;
                }
            }
        }


        for (int i = numN; i >= 2; i--)
        {
            if (arr[i] == false)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
