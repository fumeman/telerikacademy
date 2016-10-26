using System;

class PointCyrcleRectangle
{
    static void Main()
    {
        double x, y, cyrcle;
        x = Double.Parse(Console.ReadLine());
        y = Double.Parse(Console.ReadLine());
        cyrcle = Math.Sqrt(Math.Abs((x - 1)*(x - 1)) + Math.Abs((y - 1) * (y - 1)));
        string resultC = (cyrcle <= 1.5) ? "inside" : "outside";
        string resultR = ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)) ? "inside" : "outside";
        Console.WriteLine("{0} circle {1} rectangle", resultC, resultR);
    }
}
