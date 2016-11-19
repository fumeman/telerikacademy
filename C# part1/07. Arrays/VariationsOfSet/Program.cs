using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numN, numK;
        if (!int.TryParse(Console.ReadLine(), out numN))
        {
            throw new Exception("Invalid Input! #1");
        }

        if (!int.TryParse(Console.ReadLine(), out numK))
        {
            throw new Exception("Invalid Input! #1");
        }

        List<int> startList = new List<int>();
        for (int i = 1; i <= numN; i++)
        {
            startList.Add(i);
        }
        List<List<int>> listOfLists = new List<List<int>>();

        listOfLists = GetVariations(numK, startList);

        foreach (List<int> list in listOfLists)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i == list.Count - 1)
                {
                    Console.Write("{0}{1}, ", '{', list[i]);
                }
                else if (i == 0)
                {
                    Console.WriteLine("{1}{0}", '}', list[i]);
                }
                else
                {
                    Console.Write(", {0}", list[i]);
                }
            }
        }
    }

    public static List<List<T>> GetVariations<T>(int k, List<T> elements)
    {
        List<List<T>> result = new List<List<T>>();
        if (k == 1)
        {
            result.AddRange(elements.Select(element => new List<T>() { element }));
        }
        else
        {
            foreach (T element in elements)
            {
                List<T> subelements = elements;
                //List<T> subelements = elements.Where(e => !e.Equals(element)).ToList();
                List<List<T>> subvariations = GetVariations(k - 1, subelements);
                foreach (List<T> subvariation in subvariations)
                {
                    subvariation.Add(element);
                    result.Add(subvariation);
                }
            }
        }
        return result;
    }
}
