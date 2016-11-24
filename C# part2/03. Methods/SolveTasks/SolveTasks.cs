using System;

class SolveTasks
{
    static void PressAKey()
    {
        Console.Write("Press any key to continue . . .");
        Console.ReadLine();
    }

    static void Revers()
    {
        double number;
        bool flag;
        do
        {
            flag = false;
            Console.Clear();
            Console.WriteLine();
            Console.Write("Enter decimal number to revert: ");
            if (!double.TryParse(Console.ReadLine(), out number))
            {
                flag = true;
            }
        } while (flag || number < 0);


        string str = number.ToString(), tmp = "";
        for (int i = 0; i < str.Length; i++)
        {
            tmp = str[i] + tmp;
        }
        Console.WriteLine("Revert {1} is {0}", tmp, str);
        PressAKey();
    }

    static void Average()
    {
        bool flag;
        int[] arr;
        do
        {
            flag = false;
            Console.Clear();
            Console.WriteLine();
            Console.Write("Enter sequence of integers separated by space: ");
            string[] str = Console.ReadLine().Split(' ');
            arr = new int[str.Length];
            if (str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(!int.TryParse(str[i], out arr[i]))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                flag = true;
            }
        } while (flag);

        double average = 0;
        foreach (var numbers in arr)
        {
            average += numbers;
        }

        Console.WriteLine("Average of a sequence is {0:F}", average / arr.Length);
        PressAKey();
    }

    static void Equation()
    {
        double A, B, X;
        bool flag;
        do
        {
            flag = false;
            Console.Write("Enter a: ");
            if(!double.TryParse(Console.ReadLine(), out A))
            {
                flag = true;
            }
            if (A == 0)
            {
                flag = true;
            }
        } while (flag);

        do
        {
            flag = false;
            Console.Write("Enter b: ");
            if (!double.TryParse(Console.ReadLine(), out B))
            {
                flag = true;
            }
        } while (flag);

        X = -B / A;

        Console.WriteLine("Solution of the equation is x = {0}", X);
        PressAKey();
    }

    static void Main()
    {
        byte choice = 5;
        while (choice != 4)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1. Reverses the digits of a number");
                Console.WriteLine("2. Calculates the average of a sequence of integers");
                Console.WriteLine("3. Solves a linear equation a * x + b = 0");
                Console.WriteLine("4. Exit");
                Console.Write("Your Choice: ");
                if (!byte.TryParse(Console.ReadLine(), out choice))
                {
                    choice = 0;
                }
            } while (0 >= choice || choice > 4);

            switch (choice)
            {
                case 1:
                    Revers();
                    break;
                case 2:
                    Average();
                    break;
                case 3:
                    Equation();
                    break;
                default:
                    break;
            }
        }
    }
}
