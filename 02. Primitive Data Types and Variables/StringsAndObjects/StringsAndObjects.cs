using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
        string str3 = (string)obj;
        Console.WriteLine("str3 = {0}", str3);
    }
}
