using System;
using System.Collections.Generic;

class NumberCalculations
{
    static string[] Calcul(long[] arr)
    {
        string[] result = new string[arr.Length];

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        long product = 1;

        foreach (int number in arr)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }

            sum += number;

            product *= number;
        }

        double average = (double)sum / (double)arr.Length;

        result[0] = min.ToString();
        result[1] = max.ToString();
        result[2] = average.ToString("F");
        result[3] = sum.ToString();
        result[4] = product.ToString();

        return result;
    }

    static List<T> GetInitializedList<T>(T value, int count)
    {
        // This generic method returns a List with ten elements initialized.
        // ... It uses a type parameter.
        // ... It uses the "open type" T.
        List<T> list = new List<T>();
        for (int i = 0; i < count; i++)
        {
            list.Add(value);
        }
        return list;
    }


    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');

        List<T> list = GetInitializedList(str, str.Length);

        //long[] arr = new long[str.Length];
        //for (int i = 0; i < str.Length; i++)
        //{
        //    arr[i] = long.Parse(str[i]);
        //}

        //List<var> list1 = GetInitializedList(true, 5);
        //List<string> list2 = GetInitializedList<string>("Perls", 3);
        //foreach (bool value in list1)
        //{
        //    Console.WriteLine(value);
        //}
        //foreach (string value in list2)
        //{
        //    Console.WriteLine(value);
        //}



        foreach (string number in Calcul(arr))
        {
            Console.WriteLine(number);
        }
    }
}
