using System;

class SpiralMatrix
{
    static void Main()
    {
        int numN;
        do
        {
            int.TryParse(Console.ReadLine(), out numN);
        } while /*(numN < 1 || numN > 20)*/ (false);


        int counter = 1;
        int maxX = numN - 1 , maxY = numN - 1, minX = 0, minY = 1, x = 0, y = 0;
        int[,] arr = new int [numN, numN];
        

        while (counter <= numN * numN)
        {
            while (x <= maxX && counter <= numN * numN)     //  ->
            {                                               // ----
                arr[x, y] = counter;                        // |  |
                x++;                                        // |  |
                counter++;                                  // ----
            }
            x--;
            maxX--;
            y++;

            while (y <= maxY && counter <= numN * numN)     // ----
            {                                               // |  |  |
                arr[x, y] = counter;                        // |  |  \/
                y++;                                        // ----
                counter++;
            }
            y--;
            maxY--;
            x--;

            while (x >= minX && counter <= numN * numN)     // ----
            {                                               // |  |
                arr[x, y] = counter;                        // |  |
                x--;                                        // ----
                counter++;                                  //  <-
            }
            x++;
            minX++;
            y--;

            while (y >= minY && counter <= numN * numN)     //     ----
            {                                               //  /\ |  |
                arr[x, y] = counter;                        //  |  |  |
                y--;                                        //     ----
                counter++;
            }
            y++;
            minY++;
            x++;
        }
        for (byte i = 0; i < numN; i++)
        {
            for (byte j = 0; j < numN; j++)
            {

                if (j == 0)
                {
                    Console.Write("{0}", arr[j, i]);
                }
                else
                {
                    Console.Write(" {0}", arr[j, i]);
                }
            }
            Console.WriteLine();
        }
    }
}