using System;

namespace SquareRoot
{
    class Startup
    {
        static void Main()
        {
            double number;
            try
            {
                number = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                if (double.IsNaN(result))
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:0.000}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
