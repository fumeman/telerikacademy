using System;
using System.Globalization;
using System.Text;

namespace DateInBulgarian
{
    class Program
    {
        static void Main()
        {
            string[] DateArr = Console.ReadLine().Split(new char[] { '.', ':', ' ' });

            for (int i = 3; i < 6; i++)
            {
                if (DateArr[i].Length < 2)
                {
                    DateArr[i] = DateArr[i].PadLeft(2, '0');
                }
            }

            StringBuilder DateString = new StringBuilder();
            DateString.Append(DateArr[0] + '.' + DateArr[1] + '.' + DateArr[2]+' ');
            DateString.Append(DateArr[3] + ':' + DateArr[4] + ':' + DateArr[5]);

            DateTime date = DateTime.ParseExact(DateString.ToString(), "dd.MM.yyyy HH:mm:ss", null, DateTimeStyles.None);
            CultureInfo culture = new CultureInfo("bg-BG");
            Console.WriteLine("{0}, {1}", date.AddHours(6.5), culture.DateTimeFormat.GetDayName(date.DayOfWeek));
        }
    }
}
