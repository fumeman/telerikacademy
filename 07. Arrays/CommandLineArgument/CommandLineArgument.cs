using System;

class CommandLineArgument
{
    static void Main(string[] args)
    {
        long sum = 0;
        foreach (string str in args)
        {
            int num = int.Parse(str);
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
