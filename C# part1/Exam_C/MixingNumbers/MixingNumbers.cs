using System;

class MixingNumbers
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input!");
            }
        } while (numN < 2 || numN > 1000);

        byte[] arr = new byte[numN];

        for (int i = 0; i < numN; i++)
        {
            do
            {
                if (!byte.TryParse(Console.ReadLine(), out arr[i]))
                {
                    throw new Exception("Invalid Input!");
                }
            } while (arr[i] < 10 || arr[i] > 99);
        }

        for (int i = 0; i < numN - 1; i++)
        {
            int calc = (arr[i] % 10) * (arr[i + 1] / 10);   //mixed numbers
            if (i < numN - 2)
            {
                Console.Write("{0} ", calc);
            }
            else
            {
                Console.WriteLine(calc);
            }
        }

        for (int i = 0; i < numN - 1; i++)
        {
            int calc = (Math.Abs(arr[i] - arr[i+1]));   //subtracted numbers
            if (i < numN - 2)
            {
                Console.Write("{0} ", calc);
            }
            else
            {
                Console.WriteLine(calc);
            }
        }
    }
}

