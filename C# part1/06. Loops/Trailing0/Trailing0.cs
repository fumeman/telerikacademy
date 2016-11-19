using System;

class Trailing0
{
    static void Main()
    {
        int numA;
        if (!int.TryParse(Console.ReadLine(), out numA))
        {
            throw new Exception("Invalid Input!");
        }

        int counter = 0;
        for (int i = 1; i <= numA; i++)
        {
            int tmp = i;
            while (tmp % 5 == 0)
            {
                counter++;
                tmp = tmp / 5; 
            }
        }
        Console.WriteLine(counter);
    }
}
