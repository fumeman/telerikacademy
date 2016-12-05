using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SingingCats
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string current = string.Empty;
            Dictionary<int, int> catsAndSongs = new Dictionary<int, int>();
            List<string> shits = new List<string>();
            while (current != "Mew!")
            {
                current = Console.ReadLine();
                shits.Add(current);
            }

            for (int i = 0; i < shits.Count; i++)
            {
                MatchCollection nums = Regex.Matches(shits[i], @"[0-9]");
                for (int j = 0; j < nums.Count; j++)
                {
                    if (j + 1 < nums.Count)
                    {
                        int c = int.Parse(nums[j].ToString());
                        int c1 = int.Parse(nums[j + 1].ToString());
                        if (catsAndSongs.ContainsKey(c))
                        {
                            catsAndSongs[c] = c1;
                        }
                        else
                        {
                            catsAndSongs.Add(c, c1);
                        }
                    }
                }
            }

            int howManySongs = 0;
            for (int i = 0; i < catsAndSongs.Count; i++)
            {
                var item = catsAndSongs.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;
                howManySongs++;
            }

            string cats = string.Empty;
            for (int i = 0; i < firstLine.Length; i++)
            {
                if (Char.IsDigit(firstLine[i]))
                {
                    cats += firstLine[i];
                }
            }

            int catsAsInt = int.Parse(cats);
            string songs = string.Empty;

            for (int i = 0; i < secondLine.Length; i++)
            {
                if (Char.IsDigit(secondLine[i]))
                {
                    songs += secondLine[i];
                }
            }
            int songsAsInt = int.Parse(songs);
        }
    }
}