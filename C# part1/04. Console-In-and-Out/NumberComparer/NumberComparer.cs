using System;

class NumberComparer
{
    static void Main()
    {
        double A = Double.Parse(Console.ReadLine());
        double B = Double.Parse(Console.ReadLine());
        string str = (A > B) ? Convert.ToString(A) : Convert.ToString(B);
        Console.WriteLine(str);
    }
}
