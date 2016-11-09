using System;


class MaximalSequence
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                numN = 0;
            }
        } while (1 > numN || numN > 1024);

        long num, tmpNum = 0, count = 0, maxCount = 1;
        for (int i = 0; i < numN; i++)
        {
            if (!long.TryParse(Console.ReadLine(), out num))
            {
                num = 0;
            }
            if (tmpNum == num)
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            else
            {
                tmpNum = num;
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
    }
}

