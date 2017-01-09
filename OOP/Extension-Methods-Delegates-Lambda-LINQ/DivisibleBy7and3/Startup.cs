namespace DivisibleBy7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            int[] array = { 11, 21, 35, 46, 56, 84, 71, 18, 105 };

            Console.WriteLine($"Divisibles by 7 and 3:");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Extension method: {array.DivisibleBy7and3()}");

            List<int> divBy7and3 = array.Where(n => n % 21 == 0).ToList();
            Console.WriteLine($"Lambda: {String.Join(", ", divBy7and3)}");

            divBy7and3 = (from number in array where (number % 21 == 0) select number).ToList();
            Console.WriteLine($"LINQ expression: {String.Join(", ", divBy7and3)}");
        }
    }
}
