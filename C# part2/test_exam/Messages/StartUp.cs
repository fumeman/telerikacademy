using System;
using System.Numerics;

namespace Messages
{
    class StartUp
    {
        static string[] arr = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        static BigInteger CodeToNum(string str)
        {
            BigInteger result = 0;

            string[] code = new string[str.Length / 3];
            for (int i = 0; i < str.Length; i += 3)
            {
                code[(i / 3)] = str.Substring(i, 3);
            }

            
            foreach (var item in code)
            {
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    if (arr[i] == item)
                //    {
                //        result = result * 10 + i;
                //        break;
                //    }
                //}
                //result = result * 10 + Array.FindIndex(arr, row => row.Contains(item));
                result = result * 10 + Array.IndexOf(arr, item);
            }

            return result;
        }

        static string NumToCode(BigInteger num)
        {
            string result = String.Empty;

            while (num > 0)
            {
                result = arr[(int)(num % 10)] + result;
                num /= 10;
            }

            return result;
        }

        static void Main()
        {
            string firstNum = Console.ReadLine();
            string operat0r = Console.ReadLine();
            string secondNum = Console.ReadLine();

            if (operat0r == "+")
            {
                Console.WriteLine(NumToCode(CodeToNum(firstNum) + CodeToNum(secondNum)));
            }
            else
            {
                Console.WriteLine(NumToCode(CodeToNum(firstNum) - CodeToNum(secondNum)));
            }
        }
    }
}
