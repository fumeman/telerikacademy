using System;

class NumberAsArray
{
    static string Calcul(int[] arr1, int[] arr2)
    {
        string result = "";
        int sum = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            sum += arr1[i] + arr2[i];
            result = (sum % 10).ToString() + result;
            sum = sum / 10;
        }
        for (int i = arr2.Length; i < arr1.Length; i++)
        {
            sum += arr1[i];
            result = (sum % 10).ToString() + result;
            sum = sum / 10;
        }
        if (sum == 1)
        {
            result = (sum % 10).ToString() + result;
        }

        return result;
    }

    static int[] SumOfArrays(int[] arr1, int[] arr2)
    {
        string str;
        
        if (arr1.Length >= arr2.Length)
        {
            str = Calcul(arr1, arr2);
        }
        else
        {
            str = Calcul(arr2, arr1);
        }

        int[] result = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            result[str.Length - 1 - i] = str[i] - 48;
        }

        return result;
    }

    static void Main()
    {
        string[] tmp = Console.ReadLine().Split(' ');
        int numA = int.Parse(tmp[0]);
        int numB = int.Parse(tmp[1]);

        tmp = Console.ReadLine().Split(' ');
        int[] arrA = new int[numA];
        for (int i = 0; i < numA; i++)
        {
            arrA[i] = int.Parse(tmp[i]);
        }

        tmp = Console.ReadLine().Split(' ');
        int[] arrB = new int[numB];
        for (int i = 0; i < numB; i++)
        {
            arrB[i] = int.Parse(tmp[i]);
        }


        int[] arrC = SumOfArrays(arrA, arrB);

        for (int i = 0; i < arrC.Length - 1; i++)
        {
            Console.Write("{0} ", arrC[i]);
        }
        Console.WriteLine(arrC[arrC.Length - 1]);
    }
}
