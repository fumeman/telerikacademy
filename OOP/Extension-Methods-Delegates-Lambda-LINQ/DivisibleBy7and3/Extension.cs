namespace DivisibleBy7and3
{
    using System.Collections.Generic;
    using System;

    public static class Extension
    {
        public static string DivisibleBy7and3(this IEnumerable<int> enumeration)
        {
            List<int> allDivisibleBy3and7 = new List<int>();
            foreach (var number in enumeration)
            {
                if (number % 21 == 0)
                {
                    allDivisibleBy3and7.Add(number);
                }
            }

            return string.Join(", ", allDivisibleBy3and7);
        }
    }
}
