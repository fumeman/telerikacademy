using System;

class IntDoubleString
{
    static void Main()
    {
        bool flag;
        string input1, input2;
        int integer;
        double real;
        do
        {
            flag = false;
            input1 = Console.ReadLine();
            if (input1 == "integer")
            {
                input2 = Console.ReadLine();
                if (!Int32.TryParse(input2, out integer))
                {
                    integer = 0;
                }
                Console.WriteLine(integer + 1);
            }
            else if (input1 == "real")
            {
                input2 = Console.ReadLine();
                if (!Double.TryParse(input2, out real))
                {
                    real = 0;
                }
                Console.WriteLine("{0:f2}", real + 1);
            }
            else if (input1 == "text")
            {
                input2 = Console.ReadLine();
                Console.WriteLine("{0}*", input2);
            }
            else
            {
                flag = true;
            }
        } while (flag);
    }
}
