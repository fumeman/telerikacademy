using System;

class CompareCharArrays
{
    static void Main()
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        char[] arr1 = new char[str1.Length];
        char[] arr2 = new char[str2.Length];

        for (int i = 0; i < str1.Length; i++)
        {
            arr1[i] = str1[i];
        }

        for (int i = 0; i < str2.Length; i++)
        {
            arr2[i] = str2[i];
        }

        bool flag = false;
        int small = Math.Min(str1.Length, str2.Length);
        for (int i = 0; i < small; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine("<");
                flag = true;
                break;
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine(">");
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("=");
            }
            else if (str1.Length > str2.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
