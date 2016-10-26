using System;

class SumOfNNumbers
{
    static void Main()
    {
        try
        {
            string number;
            int N;
            do
            {
                number = Console.ReadLine();
                bool result = Int32.TryParse(number, out N);
                if (!result) N = 0; 
            } while (N < 1 || N > 200);
            double tmp;
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                do
                {
                    number = Console.ReadLine();
                    bool result = Double.TryParse(number, out tmp);
                    if (!result) tmp = 0;
                } while (tmp < -1000 || tmp > 1000);
                sum += tmp;
            }
            Console.WriteLine("{0}", sum);
        }
        catch { Console.WriteLine("Err"); };
    }
}
