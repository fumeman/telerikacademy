using System;

class HiddenMessage
{
    static void Main()
    {
        string I = "", S, subs, myText = "";

        while (true)
        {
            I = Console.ReadLine();
            if (I == "end")
            {
                Console.WriteLine(myText);
                break;
            }
            if (I != "")
            {
                S = Console.ReadLine();
                subs = Console.ReadLine();
                int numS;
                do
                {
                    if (!int.TryParse(S, out numS))
                    {
                        throw new Exception("Invalid Input");
                    }
                } while (numS < -100 || numS == 0 || numS > 100);

                int numI;
                do
                {
                    if (!int.TryParse(I, out numI))
                    {
                        throw new Exception("Invalid Input");
                    }
                } while (numI < -100 || numI > 100);

                if (numI < 0)
                {
                    numI = subs.Length + numI;
                }
                while (numI < subs.Length && numI >= 0)
                {
                    myText += subs[numI];
                    numI += numS;
                }
            }
        }
    }
}
