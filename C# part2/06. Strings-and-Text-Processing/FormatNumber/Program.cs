using System;
using System.Numerics;

namespace FormatNumber
{
    class StartUp
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:D15}", (BigInteger)num);
            Console.WriteLine("{0:X15}", (BigInteger)num);
            Console.WriteLine("{0:P15}", num);
            Console.WriteLine("{0:E15}", num);
        }
    }
}
