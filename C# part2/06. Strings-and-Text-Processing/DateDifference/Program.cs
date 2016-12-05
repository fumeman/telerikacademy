using System;
using System.Globalization;

namespace DateDifference
{
    class Program
    {
        static void Main()
        {
            string[] firstDateArr = Console.ReadLine().Split('.');
            string[] secondDateArr = Console.ReadLine().Split('.');

            for (int i = 0; i < 2; i++)
            {
                if (firstDateArr[i].Length < 2)
                {
                    firstDateArr[i] = '0' + firstDateArr[i];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (secondDateArr[i].Length < 2)
                {
                    secondDateArr[i] = '0' + secondDateArr[i];
                }
            }

            if (secondDateArr[2].Length < 4)
            {
                secondDateArr[2] = secondDateArr[2].PadLeft(4, '0');
            }

            if (firstDateArr[2].Length < 4)
            {
                firstDateArr[2] = firstDateArr[2].PadLeft(4, '0');
            }

            string firstDateString = String.Join(".", firstDateArr);
            string secondDateString = String.Join(".", secondDateArr);
            DateTime firstDate, secondDate;

            firstDate = DateTime.ParseExact(firstDateString, "dd.MM.yyyy", null, DateTimeStyles.None);
            secondDate = DateTime.ParseExact(secondDateString, "dd.MM.yyyy", null, DateTimeStyles.None);

            Console.WriteLine("{0}", (secondDate - firstDate).TotalDays);
        }
    }
}
