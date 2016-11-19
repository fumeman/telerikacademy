using System;

class Program
{
    static void Main()
    {
        byte[] letters = new byte[26];
        for (byte b = 97; b <= 122; b++)
        {
            letters[b - 97] = b;
        }

        string word;
        do
        {
            word = Console.ReadLine().ToLower();
        } while (word.Length > 128 || word.Length < 1);

        for (byte b = 0; b<word.Length; b++ )
        {
            for (byte a = 0; a < letters.Length; a++)
            {
                if (letters[a] == word[b])
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }
    }
}
