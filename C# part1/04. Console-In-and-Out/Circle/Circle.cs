using System;

class Circle
{
    static void Main()
    {
        double radius = Double.Parse(Console.ReadLine());
        //Console.WriteLine("{0} {1}", Math.Round(2 * Math.PI * radius, 2), Math.Round(Math.PI * radius * radius, 2));
        Console.WriteLine(string.Format("{0:F2} {1:F2}", (2 * Math.PI * radius), (Math.PI * radius * radius)));
    }
}
