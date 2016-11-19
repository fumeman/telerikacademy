using System;

class BinarySearch
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input");
            }
        } while (1 > numN || numN > 1024);

        double[] arr = new double[numN];
        for (int i = 0; i < numN; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }

        double numX;
        if (!double.TryParse(Console.ReadLine(), out numX))
        {
            throw new Exception("Invalid Input");
        }

        //int position = numN / 2, oldPosition = numN - 1, middlePosition = 0, counter = 0;
        int position = numN / 2, oldPosition = 0, counter = 0;
        bool flag = false;
        while ((numX != arr[position]) && counter <= numN / 2)
        {
            counter++;
            if (numX > arr[position])
            {
                oldPosition = position;
                position = (position + numN) / 2;
            }
            else if (numX < arr[position])
            {
                position = (position + oldPosition) / 2;
            }
        }
        
        if (counter <= numN/2)
        {
            flag = true;
        }

        //bool flag = false;
        //while (middlePosition <= oldPosition)
        //{
        //    position = (middlePosition + oldPosition) / 2;
        //    if (numX == arr[position])
        //    {
        //        flag = true;
        //        break;
        //    }
        //    else if (numX < arr[position])
        //    {
        //        oldPosition = position - 1;
        //    }
        //    else
        //    {
        //        middlePosition = position + 1;
        //    }
        //}
        if (flag)
        {
            Console.WriteLine(position);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}
