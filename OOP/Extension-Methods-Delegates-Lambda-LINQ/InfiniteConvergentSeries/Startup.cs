namespace InfiniteConvergentSeries
{
    using System;
    using MathNet.Numerics;

    delegate double Predicate(string value);

    class Startup
    {
        public const double tolerance = 0.01;

        public static double First()
        {
            double sum = 0, y = 0;
            double n = 1;
            do
            {
                y = sum;
                sum += 1 / n;
                n *= 2;
            } while (sum - y > tolerance);

            return sum;
        }

        public static double Second()
        {
            double sum = 0, y;
            double n = 1;
            do
            {
                y = sum;
                double tmp = 1;
                for (double i = n; i > 1; i--)
                {
                    tmp *= i;
                }
                sum += 1 / tmp;
                n++;
            } while (sum - y > tolerance);

            return sum;
        }

        public static double Third()
        {
            double sum = 1, y;
            double n = 2;
            int counter = 2;
            do
            {
                y = sum;
                sum = (counter % 2 == 0) ? sum + 1 / n : sum - 1 / n;
                n *= 2;
                counter++;
            } while (sum - y > tolerance);

            return sum;
        }

        public static double ConvergentSum(Func<int, double> termValue, double precision)
        {
            double sum = 0, y;
            int n = 1;
            do
            {
                y = sum;
                sum += termValue.Invoke(n);
                n++;
            } while (sum - y > precision);

            return sum;
        }


        static void Main()
        {
            Console.WriteLine(ConvergentSum(index => 1 / Math.Pow(2, index - 1), 0.01));
            Console.WriteLine(First().ToString());
            Console.WriteLine(ConvergentSum(index => 1 / SpecialFunctions.Factorial(index), 0.01));
            Console.WriteLine(Second().ToString());
            Console.WriteLine(ConvergentSum(index => ((index % 2 == 0) || (index == 1)) ? 1 / Math.Pow(2, index - 1) : -1 / Math.Pow(2, index - 1), 0.01));
            Console.WriteLine(Third().ToString());
        }
    }
}
