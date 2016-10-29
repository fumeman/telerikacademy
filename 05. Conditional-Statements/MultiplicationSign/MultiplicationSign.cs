using System;

class MultiplicationSign
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

        if ((numA > 0 && numB > 0 && numC > 0) || (numA > 0 && numB < 0 && numC < 0) || (numA < 0 && numB > 0 && numC < 0) || (numA < 0 && numB < 0 && numC > 0))
        {
            Console.WriteLine("+");
        }
        else if ((numA > 0 && numB > 0 && numC < 0) || (numA > 0 && numB < 0 && numC > 0) || (numA < 0 && numB > 0 && numC > 0) || (numA < 0 && numB < 0 && numC < 0))
        {
            Console.WriteLine("-");
        }
        else if (numB == 0 || numA == 0 || numC == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            throw new Exception("There is something wrong!!!");
        }
    }
}
