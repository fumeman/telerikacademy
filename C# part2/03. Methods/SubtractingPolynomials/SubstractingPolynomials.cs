using System;

class SubstractingPolynomials
{
    static int[] AddPolynoms(int[] poly1, int[] poly2)
    {
        int[] result = new int[poly1.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = poly1[i] - poly2[i];
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

        int[] arr1 = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr1[i] = int.Parse(str[i]);
        }

        str = Console.ReadLine().Split(' ');
        int[] arr2 = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr2[i] = int.Parse(str[i]);
        }

        int counter = 0;
        foreach (int number in AddPolynoms(arr1, arr2))
        {
            if (counter++ == 0)
            {
                Console.Write("{0}", number);
            }
            else
            {
                Console.Write(" {0}", number);
            }
        }
        Console.WriteLine();
    }
}
