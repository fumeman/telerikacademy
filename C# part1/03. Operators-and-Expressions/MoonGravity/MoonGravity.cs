using System;

class MoonGravity
{
    static void Main()
    {
        float W, moonW;
        W = Single.Parse(Console.ReadLine());
        moonW = W * 0.17f;
        Console.WriteLine(moonW.ToString("0.000"));
    }
}
