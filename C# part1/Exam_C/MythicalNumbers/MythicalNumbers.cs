using System;

class MythicalNumbers
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input!");
            }

        } while (100 > numN || numN > 999);

        int tmp = numN / 100;
        double first = tmp;
        tmp = (numN / 10) % 10;
        double second = tmp;
        tmp = numN % 10;
        double third = tmp;

        double product;

        if (third == 0)
        {
            product = first * second;
        }
        else if (third > 0 && third <= 5)
        {
            product = (first * second) / third;
        }
        else
        {
            product = (first + second) * third;
        }
            Console.WriteLine("{0:f2}", product);
    }
}
