using System;

class CountAge
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        String birthdate = Console.ReadLine();
        DateTime birthd = DateTime.ParseExact(birthdate, "MM.dd.yyyy", null);
        int age = today.Year - birthd.Year;
        if ((birthd.Day > today.Day && birthd.Month < today.Month) || (birthd.Day <= today.Day && birthd.Month <= today.Month))
        { 
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
        else
        {
            Console.WriteLine(age - 1);
            Console.WriteLine(age + 9);
        }

    }
}