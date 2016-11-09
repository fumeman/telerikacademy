using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input! #1");
            }
        } while (1 > numN || numN > 1024);

        List<int> arr = new List<int>();
        int num;

        for (int i = 0; i < numN; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                throw new Exception("Invalid Input! #2");
            }
            arr.Add(num);
        }

        arr = merge_sort(arr);

        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static List<int> merge_sort(List<int> sortArr)
    {
        // list of one or less elements is sorted, by definition.
        if (sortArr.Count <= 1)
        {
            return sortArr;
        }

        List<int> arrLeft = new List<int>();
        List<int> arrRight = new List<int>();

        for (int i = 0; i < sortArr.Count; i++)
        {
            if (i < sortArr.Count / 2)
            {
                arrLeft.Add(sortArr[i]);
            }
            else
            {
                arrRight.Add(sortArr[i]);
            }
        }

        arrLeft = merge_sort(arrLeft);
        arrRight = merge_sort(arrRight);

        // Merge the now-sorted sublists.
        return merge(arrLeft, arrRight);
    }

    static List<int> merge(List<int> left, List<int> right)
    {
        List<int> merged = new List<int>();

        while (left.Count > 0 && right.Count > 0)
        {
            if (left[0] <= right[0])
            {
                merged.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                merged.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        while (left.Count > 0)
        {
            merged.Add(left[0]);
            left.RemoveAt(0);
        }
        while (right.Count > 0)
        {
            merged.Add(right[0]);
            right.RemoveAt(0);
        }
        return merged;
    }
}
