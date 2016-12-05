using System;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                Console.Write("{1}u{0,0:X4}", (byte)ch, (char)0x5c);
            }
            Console.WriteLine();
        }
    }
}
