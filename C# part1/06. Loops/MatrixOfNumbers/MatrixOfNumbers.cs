using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int numN;
        do
        {
            Int32.TryParse(Console.ReadLine(), out numN);
        } while (numN < 1 || numN > 20);

        int tmp = 0;
        for (int i = 1; i <= (numN * numN); i++)
        {
            tmp++;

            if (i % numN == 1)
            {
                Console.Write("{0}", tmp);
            }
            else
            {
                Console.Write(" {0}", tmp);
            }

            if (i % numN == 0)
            {
                tmp = (i / numN);
                Console.WriteLine();
            }
        }
    }
}
