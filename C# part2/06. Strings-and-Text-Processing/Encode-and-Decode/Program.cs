using System;
using System.Text;

namespace Encode_and_Decode
{
    class StartUp
    {
        static void Main()
        {
            string cipher = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine(coder(text, cipher));
        }

        static StringBuilder coder(string text, string cipher)
        {
            StringBuilder result = new StringBuilder();

            int index = 0;
            foreach (char ch in text)
            {
                result.Append((char)(ch ^ cipher[index++]));
                if (index >= cipher.Length)
                {
                    index = 0;
                }
            }

            return result;
        }
    }
}
