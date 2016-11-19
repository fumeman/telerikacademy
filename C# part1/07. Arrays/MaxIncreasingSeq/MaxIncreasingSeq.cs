using System;


class MaxIncreasingSeq
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

        long num, tmpNum = 0, count = 1, maxCount = 1;
        for (int i = 0; i < numN; i++)
        {
            if (!long.TryParse(Console.ReadLine(), out num))
            {
                throw new Exception("Invalid input");
            }
            if (i > 0)
            {
                if (tmpNum < num)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            tmpNum = num;
        }
        Console.WriteLine(maxCount);
    }
}