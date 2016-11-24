using System;

class EnglishDigit
{
    static string ReturnWord(string num)
    {
        string result = "-1";

        string[] arr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        result = arr[num[num.Length - 1] - 48];

        return result;
    }

    static void Main()
    {
        Console.WriteLine(ReturnWord(Console.ReadLine()));
    }
}
