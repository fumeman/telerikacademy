using System;

class CompareArrays
{
    static void Main()
    {
        uint numN;
        if (!uint.TryParse(Console.ReadLine(), out numN))
        {
            numN = 0;
        }
        int[] arr1 = new int[numN];
        int[] arr2 = new int[numN];

        for (uint i = 0; i < numN; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr1[i]))
            {
                arr1[i] = 0;
            }
        }

        for (uint i = 0; i < numN; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr2[i]))
            {
                arr2[i] = 0;
            }
        }

        bool flag = true;
        for (uint i = 0; i < numN; i++)
        {
            if (arr1[i] != arr2[i])
            {
                flag = false;
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
