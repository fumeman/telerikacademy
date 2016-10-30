using System;

class MMSAofN_Numbers
{
    static void Main()
    {
        int numN;
        string input;
        do
        {
            input = (Console.ReadLine());
            if (!int.TryParse(input, out numN))
            {
                numN = 0;
            }
        } while (numN < 1 || numN > 1000);

        double enterNumber, min = double.MaxValue, max = double.MinValue;
        double sum = 0;
        
        for (int i = 1; i <= numN; i++)
        {
            bool condition = Double.TryParse(Console.ReadLine(), out enterNumber);
            if (!condition) throw new Exception("Error on input");
            
            sum += enterNumber;

            if (enterNumber > max)
            {
                max = enterNumber;
            }

            if (enterNumber < min)
            {
                min = enterNumber;
            }
        }
        Console.WriteLine("min={0:f2}", min);
        Console.WriteLine("max={0:f2}", max);
        Console.WriteLine("sum={0:f2}", sum);
        Console.WriteLine("avg={0:f2}", (sum / numN));
    }
}
