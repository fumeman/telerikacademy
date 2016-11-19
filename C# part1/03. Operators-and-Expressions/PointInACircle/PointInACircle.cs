using System;

class PointInACircle
{
    static void Main()
    {
        double x, y, distance;
        x = Double.Parse(Console.ReadLine());
        y = Double.Parse(Console.ReadLine());
        distance = Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y));
        string result = (distance <= 2) ? "yes" : "no";
        Console.WriteLine("{0} {1}", result, distance.ToString("0.00"));
    }
}
