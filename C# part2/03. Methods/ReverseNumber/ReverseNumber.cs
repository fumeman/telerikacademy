using System;

class ReverseNumber
{
    static string Reverse(string Decimal)
    {
        string result = "";

        foreach (char number in Decimal)
        {
            result = number + result;
        } 

        return result;
    }

    static void Main()
    {
        Console.WriteLine(Reverse(Console.ReadLine()));
    }
}
