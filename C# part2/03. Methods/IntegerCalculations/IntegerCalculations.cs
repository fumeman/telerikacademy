using System;

class IntegerCalculations
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

    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');

        long[] arr = new long[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = long.Parse(str[i]);
        }

        foreach (string number in Calcul(arr))
        {
                Console.WriteLine(number);
        }
    }
}
