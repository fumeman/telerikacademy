using System;

class BinaryFloatingPoint
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        byte sign;
        if (num < 0)
        {
            sign = 1;
            num *= -1;
        }
        else
        {
            sign = 0;
        }

        double fraction, tmpFr;
        int count = 0;

        if (num >= 1)
        {
            do
            {
                fraction = num / Math.Pow(2, ++count);
            } while (fraction >= 2 || fraction < 1);
        }
        else
        {
            do
            {
                fraction = num / Math.Pow(2, --count);
            } while (fraction >= 2 || fraction < 1);
        }
        fraction--;
        int exponent = 127 + count;

        tmpFr = fraction;
        string fractionBin = "";
        for (int i = 0; i < 24; i++)
        {
            tmpFr *= 2;
            if (tmpFr >= 1)
            {
                fractionBin = fractionBin + "1";
                tmpFr--;
            }
            else
            {
                fractionBin = fractionBin + "0";
            }
        }
        if (fractionBin[23] == '1')
        {
            fractionBin = fractionBin.Substring(0,22) + '1';
        }
        else
        {
            fractionBin = fractionBin.Substring(0, 22) + '0';
        }

        Console.WriteLine("{0} {1} {2}", sign, Convert.ToString(exponent, 2), fractionBin);
    }
}
