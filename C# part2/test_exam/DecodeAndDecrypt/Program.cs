using System;
using System.Text;

namespace DecodeAndDecrypt
{
    class StartUp
    {
        static int cypherLen = 0;

        static string Encode(string code)
        {
            string result = "";

            StringBuilder decoded = new StringBuilder();
            int len = code.Length - 1;
            bool isDigit = true;
            while (isDigit)
            {
                cypherLen = 10 * cypherLen + code[len--] - 0x30;
                isDigit = Char.IsDigit(code[len]);
            }

            for (int i = 0; i <= len; i++)
            {
                if (Char.IsDigit(code[i]))
                {
                    decoded.Append(code[i + 1], code[i] - 0x30);
                    i++;
                }
                else
                {
                    decoded.Append(code[i]);
                }
            }
            result = decoded.ToString();

            return result;
        }

        static string Encrypt(string decoded, int cypherL)
        {
            StringBuilder result = new StringBuilder();

            string code = decoded.Substring(0, decoded.Length - cypherL);
            string cypher = decoded.Substring(decoded.Length - cypherL, cypherL);

            bool magic = false;
            if (code.Length < cypherL)
            {
                magic = true;
            }

            int index = 0;
            foreach (char ch in code)
            {
                char firstPart = (char)(((ch - 0x41) ^ (cypher[index] - 0x41)) + 0x41);
                result.Append(firstPart);
                if (magic)
                {
                    char cypherPart = (char)(cypher[index + code.Length]);
                    result[result.Length - 1] = (char)(((firstPart - 0x41) ^ (cypherPart - 0x41)) + 0x41);
                    if (index + code.Length + 1 >= cypherL)
                    {
                        magic = false;
                    }
                }
                index++;

                if (index >= cypherL)
                {
                    index = 0;
                }
            }


            return result.ToString();
        }

        static void Main()
        {
            string code = Console.ReadLine();
            Console.WriteLine(Encrypt(Encode(code), cypherLen));
        }
    }
}
