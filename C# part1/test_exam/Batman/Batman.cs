using System;

class Batman
{
    static void Main()
    {
        int numS;
        do
        {
            if (!(int.TryParse(Console.ReadLine(), out numS)))
            {
                numS = 0;
            }
        } while (numS < 5 || numS > 51);

        char ch = Convert.ToChar(Console.Read());

        int symbols = numS, spaces = 0, head = numS * 3;

        while (head > numS * 2 + 4)
        {
            Console.WriteLine("{2}{0}{1}{0}{2}", new string(ch, symbols), new string(' ', numS), new string(' ', spaces));
            symbols--; spaces++;
            head = symbols * 2 + numS;
        }

        string str = new string(' ', numS / 2 - 1);
        str = str + ch + ' ' + ch + str;
        Console.WriteLine("{2}{0}{1}{0}{2}", new string(ch, symbols), str, new string(' ', spaces));
        symbols--; spaces++;

        uint body = 1;
        while (body <= (numS - 2) / 2)
        {
            Console.WriteLine("{0}{1}{0}", new string(' ', spaces), new string(ch, symbols * 2 + numS));
            body++;
        }

        spaces = numS + 1;
        symbols = numS - 2;
        while (symbols >= 1)
        {
            Console.WriteLine("{0}{1}{0}", new string(' ', spaces), new string(ch, symbols));
            symbols -= 2;
            spaces++;
        }


        //int head = numS * 3, symbols = numS, rows = 1;

            //while (head > numS * 2 + 4)
            //{
            //    for (byte b = 1; b < rows; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (byte b = 1; b <= symbols; b++)
            //    {
            //        Console.Write(ch);
            //    }
            //    for (byte b = 1; b <= numS; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (byte b = 1; b <= symbols; b++)
            //    {
            //        Console.Write(ch);
            //    }
            //    Console.WriteLine();
            //    symbols--; rows++;
            //    head = symbols * 2 + numS;
            //}

            //for (byte b = 1; b < rows; b++)
            //{
            //    Console.Write(" ");
            //}
            //for (int i = 1; i <= symbols; i++)
            //{
            //    Console.Write(ch);
            //}
            //for (int i = 1; i < numS / 2; i++)
            //{
            //    Console.Write(" ");
            //}
            //Console.Write("{0} {0}", ch, ch);
            //for (int i = 1; i < numS / 2; i++)
            //{
            //    Console.Write(" ");
            //}
            //for (int i = 1; i <= symbols; i++)
            //{
            //    Console.Write(ch);
            //}
            //Console.WriteLine();
            //symbols--;

            //int bb = (numS - 2) / 2;

            //for (byte a = 1; a <= bb; a++)
            //{
            //    for (byte b = 1; b <= rows; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (byte b = 1; b <= (symbols * 2 + numS); b++)
            //    {
            //        Console.Write(ch);
            //    }
            //    Console.WriteLine();
            //}

            //rows = numS + 1;
            //symbols = numS - 2;
            //while (symbols >= 1)
            //{
            //    for (byte b = 1; b <= rows; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (byte b = 1; b <= symbols; b++)
            //    {
            //        Console.Write(ch);
            //    }
            //    Console.WriteLine();
            //    rows++;
            //    symbols -= 2;
            //}

    }
}
