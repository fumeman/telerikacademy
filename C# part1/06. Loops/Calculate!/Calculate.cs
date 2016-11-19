using System;

class Calculate
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
        } while /*(numN < 2 || numN > 10)*/ (false);

        double numX;
        do
        {
            if (!Double.TryParse(Console.ReadLine(), out numX))
            {
                numX = 0;
            }
        } while /*(numX < 0.5 || numX > 100)*/ (false);

        double sum = 1, factorial;
        for (int b = 1; b <= numN; b++)
        {
            factorial = 1;
            for (int f = 1; f <= b; f++)
            {
                factorial *= f;
            }
            sum += (factorial / Math.Pow(numX, b));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
