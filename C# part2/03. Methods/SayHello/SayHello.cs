using System;

class SayHello
{
    static void PrintName(string str)
    {
        Console.WriteLine("Hello, {0}!", str);
    }

    static void Main()
    {
       PrintName(Console.ReadLine());
    }
}
