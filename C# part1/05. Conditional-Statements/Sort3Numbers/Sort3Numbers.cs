using System;

class Sort3Numbers
{
    static void Main()
    {
        float numA, numB, numC;

        string input = Console.ReadLine();
        if (!Single.TryParse(input, out numA))
        {
            numA = 0;
        }

        input = Console.ReadLine();
        if (!Single.TryParse(input, out numB))
        {
            numB = 0;
        }

        input = Console.ReadLine();
        if (!Single.TryParse(input, out numC))
        {
            numC = 0;
        }

        float[] nums = { numA, numB, numC };
        float tmp;
        for (byte j = 0; j < 3; j++)
        {
            for (byte i = 0; i < 2 - j; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    tmp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = tmp;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", nums[0], nums[1], nums[2]);
    }
}
