using System;
using System.Numerics;

namespace Cards
{
    class Program
    {
        static string[] fullDeck = new string[] {
            "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
            "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
            "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
            "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"
        };

        static void Main()
        {
            int[] cards = new int[52];
            int numN = int.Parse(Console.ReadLine());
            ulong[] hands = new ulong[numN];
            ulong deck = 0;


            for (int i = 0; i < numN; i++)
            {
                hands[i] = ulong.Parse(Console.ReadLine());
                deck = hands[i] | deck;
            }

            if (deck == 4503599627370495)
            {
                Console.WriteLine("Full deck");
            }
            else
            {
                Console.WriteLine("Wa wa!");
            }

            for (int i = 0; i < numN; i++)
            {
                ulong hand = hands[i];
                int count = 0;
                while (hand != 0)
                {
                    cards[count] += (int)(hand & 1);
                    hand = hand >> 1;
                    count++;
                }
            }

            int counter = 0;

            for (int i = 0; i < 52; i++)
            {
                
                if (cards[i] % 2 != 0)
                {
                    if (counter == 0)
                    {
                        Console.Write("{0}", fullDeck[i]);
                    }
                    else
                    {
                        Console.Write(" {0}", fullDeck[i]);
                    }
                    counter++;
                }
            }
            Console.WriteLine();
        }
    }
}
