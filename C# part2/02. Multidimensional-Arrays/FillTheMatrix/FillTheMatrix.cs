using System;

class FillTheMatrix
{
    static void Main()
    {
        int numN;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Input!");
            }
        } while (numN < 1 || numN > 128);

        int[,] arr = new int[numN, numN];

        char ch;
        do
        {
            if (!char.TryParse(Console.ReadLine(), out ch))
            {
                throw new Exception("Invalid Input!");
            }
        } while (ch < 'a' || ch > 'd');

        switch (ch)
        {
            case 'a':
                int counter = 0;
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    for (int row = 0; row < arr.GetLength(0); row++)
                    {
                        arr[row, col] = ++counter;
                    }
                }
                break;

            case 'b':
                counter = 0;
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < arr.GetLength(0); row++)
                        {
                            arr[row, col] = ++counter;
                        }
                    }
                    else
                        for (int row = arr.GetLength(0) - 1; row >= 0; row--)
                        {
                            arr[row, col] = ++counter;
                        }
                }
                break;

            case 'c':
                int maxR = arr.GetLength(0), minC = 0, maxC;
                counter = 0;

                for (int col = 0; col < arr.GetLength(1); col++)            //
                {                                                           //  * 
                    counter += col + 1;                                     //  * *
                    for (int row = maxR - 1; row >= minC; row--)            //  * * * 
                    {                                                       //  * * * *
                        arr[row, col] = counter;                            //  * * * * *     
                        counter += (maxR - row + col);
                    }
                    minC++;
                    counter = arr[maxR - 1, col];
                }

                maxR = arr.GetLength(0);
                maxC = arr.GetLength(1);
                counter = arr.GetLength(0) * arr.GetLength(1) + 1;

                for (int col = maxC - 1; col > 0; col--)                    //
                {                                                           //  * * * * 
                    counter -= (maxC - col);                                //    * * *
                    for (int row = 0; row < maxR - 1; row++)                //      * *
                    {                                                       //        *
                        arr[row, col] = counter;                            //  
                        counter -= (row + maxC - col);
                    }
                    maxR--;
                    counter = arr[0, col];
                }
                break;

            case 'd':

                counter = 1;
                maxC = arr.GetLength(1) - 1;
                int minR = 0, rows = 0, cols = 0;
                maxR = arr.GetLength(0) - 1; minC = 1;


                while (counter <= arr.GetLength(0) * arr.GetLength(1))
                {
                    while (rows <= maxC && counter <= arr.GetLength(0) * arr.GetLength(1))     
                    {                                                                          //     ----
                        arr[rows, cols] = counter;                                             //  |  |  |
                        rows++;                                                                //  \/ |  |
                        counter++;                                                             //     ----
                    }
                    rows--;
                    maxC--;
                    cols++;

                    while (cols <= maxR && counter <= arr.GetLength(0) * arr.GetLength(1))     // ----
                    {                                                                          // |  | 
                        arr[rows, cols] = counter;                                             // |  | 
                        cols++;                                                                // ----
                        counter++;                                                             //  -->
                    }
                    cols--;
                    maxR--;
                    rows--;

                    while (rows >= minR && counter <= arr.GetLength(0) * arr.GetLength(1))      // ----
                    {                                                                           // |  | /\
                        arr[rows, cols] = counter;                                              // |  |  |
                        rows--;                                                                 // ----
                        counter++;                                                              
                    }
                    rows++;
                    minR++;
                    cols--;

                    while (cols >= minC && counter <= arr.GetLength(0) * arr.GetLength(1))      //  <--
                    {                                                                           //  ----
                        arr[rows, cols] = counter;                                              //  |  |
                        cols--;                                                                 //  |  |
                        counter++;                                                              //  ----
                    }
                    cols++;
                    minC++;
                    rows++;
                }
                break;

            default:
                break;
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (col == 0)
                {
                    Console.Write("{0}", arr[row, col]);
                }
                else
                {
                    Console.Write(" {0}", arr[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}

