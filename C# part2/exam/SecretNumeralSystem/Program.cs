using System;
using System.Numerics;
using System.Text;

class OneSystemToAnyOther
{
    static string[] base8 = new string[] { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
    static string[] converted = new string[4];

    static BigInteger calculate(string[] hex)
    {
        BigInteger result = 1;


        for (int i = 0; i < 4; i++)
        {
            BigInteger number = 0;
            for (int j = 0; j < hex[i].Length; j++)
            {

                char ch = hex[i][j];
                number = number * 8 + ch - 0x30;
            }

            result = result * number;
        }
        return result;
    }


    static void fromCodeToBase8(string[] nums)
    {

        string result;
        for (int i = 0; i < 4; i++)
        {
            StringBuilder number = new StringBuilder();
            int index;
            result = "";
            for (int j = 0; j < nums[i].Length; j++)
            {
                string tmp = nums[i];
                if (Char.IsLetter(tmp[j]))
                {
                    number.Append(tmp[j]);
                }
                index = -1;
                for (int k = 0; k < 8; k++)
                {
                    if (number.ToString() == base8[k])
                    {
                        if (number.ToString() == "vlad")
                        {
                            if (((j < tmp.Length - 1) && (tmp[j + 1] != 'i')) || (j == tmp.Length - 1))
                            {
                                index = k;
                                break;
                            }
                        }
                        else if (number.ToString() == "hristo")
                        {
                            if (((j<tmp.Length-1) &&  (tmp[j + 1] != 'f')) || (j == tmp.Length - 1))
                            {
                                index = k;
                                break;
                            }
                        }
                        else
                        {
                            index = k;
                            break;
                        }

                    }

                }

                if (index >= 0)
                {
                    number.Clear();
                    result += index;
                }
            }
            converted[i] = result;
        }
    }



    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(',');

        fromCodeToBase8(nums);

        Console.WriteLine(calculate(converted));

    }
}
