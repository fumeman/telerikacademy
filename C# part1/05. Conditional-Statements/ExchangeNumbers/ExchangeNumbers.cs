using System;

class ExchangeNumbers
{
    static void Main()
    {
        double numA, numB;
        string str = Console.ReadLine();
        if (!Double.TryParse(str, out numA))
        {
            numA = 0;
        }
        str = Console.ReadLine();
        if (!Double.TryParse(str, out numB))
        {
            numB = 0;
        }

        if (numA > numB)
        {
            double tmp = numA;
            numA = numB;
            numB = tmp;
        }
        Console.WriteLine("{0} {1}", numA, numB); 
    }
}
