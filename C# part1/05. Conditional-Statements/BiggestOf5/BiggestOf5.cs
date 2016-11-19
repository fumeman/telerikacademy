using System;

class BiggestOf3
{
    static void Main()
    {
        double numA, numB, numC, numD, numE, tmp;

        string input = Console.ReadLine();
        if (!Double.TryParse(input, out numA))
        {
            numA = 0;
        }

        input = Console.ReadLine();
        if (!Double.TryParse(input, out numB))
        {
            numB = 0;
        }

        input = Console.ReadLine();
        if (!Double.TryParse(input, out numC))
        {
            numC = 0;
        }

        input = Console.ReadLine();
        if (!Double.TryParse(input, out numD))
        {
            numD = 0;
        }

        input = Console.ReadLine();
        if (!Double.TryParse(input, out numE))
        {
            numE = 0;
        }

        tmp = numA;
        if (tmp < numB )
        {
            tmp = numB;
        }

        if (tmp < numC)
        {
            tmp = numC;
        }

        if (tmp < numD)
        {
            tmp = numD;
        }

        if (tmp < numE)
        {
            tmp = numE;
        }

        Console.WriteLine(tmp);
    }
}