using System;

class BiggestOf3
{
    static void Main()
    {
        double numA, numB, numC;

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

        if (numA >= numB && numA >= numC)
        {
            Console.WriteLine(numA);
        }
        else if (numB >= numA && numB >= numC)
        {
            Console.WriteLine(numB);
        }
        else if (numC >= numA && numC >= numB)
        {
            Console.WriteLine(numC);
        }
        else
        {
            throw new Exception("Error in logic...");
        }
    }
}
