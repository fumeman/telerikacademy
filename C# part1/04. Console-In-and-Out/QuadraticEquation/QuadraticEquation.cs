using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c, x;
        bool condition;
        do
        {
            condition = false;
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            if (a == 0) condition = true;
        } while (condition);
        double D = b * b - 4 * a * c;
        if (D < 0) Console.WriteLine("no real roots");
        else if (D == 0)
        {
            x = -(b / (2 * a));
            Console.WriteLine("{0:0.00}", x);
        }
        else 
        {
            x = -(b + Math.Sqrt(D)) / (2 * a);
            Double x1 = -(b - Math.Sqrt(D)) / (2 * a);
            if (x < x1)
            {
                Console.WriteLine("{0:0.00}", x);
                Console.WriteLine("{0:0.00}", x1);
            }
            else
            {
                Console.WriteLine("{0:0.00}", x1);
                Console.WriteLine("{0:0.00}", x);
            }
        }
    }
}
