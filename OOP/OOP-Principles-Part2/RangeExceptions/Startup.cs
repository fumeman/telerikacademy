namespace RangeExceptions
{
    using System;

    class Startup
    {
        static void Main()
        {
            int rangeStart = 1, rangeEnd = 100;
            DateTime dateStart = new DateTime(1980, 1, 1), dateEnd = new DateTime(2013, 12, 31, 23, 59, 59);

            int[] numbers = { 1, 100, 0, 20, 101, 200, -20, 0, 100, 201 };
            DateTime[] dates =
            {
                new DateTime(1974, 03, 05), new DateTime(1979, 12, 31, 23, 59, 59), new DateTime(1990, 11, 30),
                new DateTime(2000, 2, 2), new DateTime(2014, 03, 05), new DateTime(2013, 10, 19),
                new DateTime(2012, 03, 05), new DateTime(2016, 6, 25, 08, 30, 00), new DateTime(2014, 03, 05),
                new DateTime(2017, 8, 31), new DateTime(1880, 01, 6), new DateTime(1900, 1, 5)
            };

            foreach (int number in numbers)
            {
                try
                {
                    if (number < rangeStart || number > rangeEnd)
                    {
                        throw new InvalidRangeException<int>(rangeStart, rangeEnd);
                    }
                }
                catch (InvalidRangeException<int> exception)
                {
                    Console.WriteLine($"Number {number} -> {exception.Message}");
                }
            }

            foreach (DateTime date in dates)
            {
                try
                {
                    if (date < dateStart || date > dateEnd)
                    {
                        throw new InvalidRangeException<DateTime>(dateStart, dateEnd);
                    }
                }
                catch (InvalidRangeException<DateTime> exception)
                {
                    Console.WriteLine($"Date {date} -> {exception.Message}");
                }
            }
        }
    }
}
