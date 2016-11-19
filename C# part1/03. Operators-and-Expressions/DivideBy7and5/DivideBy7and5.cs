using System;

class DivideBy7and5
{
    static void Main()
    {
        int number;
        number = int.Parse(Console.ReadLine());
        /*if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }*/
        string str = (number % 35 == 0) ? "true" : "false";
        Console.WriteLine("{0} {1}", str, number);
    }
}
