using System;

class Rectangles
{
    static void Main()
    {
        double width, height, P, S;
        width = Double.Parse(Console.ReadLine());
        height = Double.Parse(Console.ReadLine());
        S = width * height;
        P = 2 * (width + height);
        //Console.Write(S.ToString("0.00"));
        //Console.WriteLine(P.ToString(" 0.00"));
        Console.WriteLine("{0} {1}", S.ToString("0.00"), P.ToString("0.00"));
    }
}
