using System;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] nums = input.Split(' ');

        ulong numA, numB;
        if (!UInt64.TryParse(nums[0], out numA) || !UInt64.TryParse(nums[1], out numB))
        {
            throw new Exception("Invalid Input!!!");
        }

        while (numA != numB)
        {
            if (numA > numB)
            {
                numA -= numB;
            }
            else
            {
                numB -= numA;
            }
        }
        Console.WriteLine(numA);
    }
}
