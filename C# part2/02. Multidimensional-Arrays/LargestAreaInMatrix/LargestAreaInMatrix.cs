using System;

class LargestAreaInMatrixProgram
{
    static void Main()
    {
        string[] tmp = Console.ReadLine().Split(' ');
        int numN = int.Parse(tmp[0]);
        int numM = int.Parse(tmp[1]);

        int[,] arr = new int[numN, numM];
        byte[,] walk = new byte[numN, numM];

        for (int i = 0; i < numN; i++)
        {
            tmp = Console.ReadLine().Split(' ');
            for (int j = 0; j < tmp.Length; j++)
            {
                arr[i, j] = int.Parse(tmp[j]);
            }
        }

        int max = int.MinValue;

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int counter = 1, ruler = 0;
                if (walk[row, col] == 0)
                {
                    walk[row, col] = 0xf;
                    while (true)
                    {

                        bool flag = true;

                        while (flag)
                        {
                            flag = false;

                            //let us initialize the ruler
                            //is the first element tried all directions
                            if (walk[row, col] == 0xf)
                            {
                                if (col == 0) ruler = ruler | 4;
                                if (col == arr.GetLength(1) - 1) ruler = ruler | 1;
                                if (row == 0) ruler = ruler | 8;
                                if (row == arr.GetLength(0) - 1) ruler = ruler | 2;
                            }

                            //go left
                            if (col > 0 && !flag)
                            {
                                if (walk[row, col] == 0xf)
                                {
                                    ruler = ruler | 4;
                                }
                                if (walk[row, col - 1] == 0)
                                {
                                    if (arr[row, col] == arr[row, col - 1])
                                    {
                                        walk[row, --col] = 4; //right
                                        flag = true;
                                        counter++;
                                    }
                                }
                            }
                            //go up
                            if (row > 0 && !flag)
                            {
                                if (walk[row, col] == 0xf)
                                {
                                    ruler = ruler | 8;
                                }
                                if (walk[row - 1, col] == 0)
                                {
                                    if (arr[row, col] == arr[row - 1, col])
                                    {
                                        walk[--row, col] = 8; //down
                                        flag = true;
                                        counter++;
                                    }
                                }
                            }
                            //go right
                            if (col < arr.GetLength(1) - 1 && !flag)
                            {
                                if (walk[row, col] == 0xf)
                                {
                                    ruler = ruler | 1;
                                }
                                if (walk[row, col + 1] == 0)
                                {
                                    if (arr[row, col] == arr[row, col + 1])
                                    {
                                        walk[row, ++col] = 1; //left
                                        flag = true;
                                        counter++;
                                    }
                                }
                            }
                            //go down
                            if (row < arr.GetLength(0) - 1 && !flag)
                            {
                                if (walk[row, col] == 0xf)
                                {
                                    ruler = ruler | 2;
                                }
                                if (walk[row + 1, col] == 0)
                                {
                                    if (arr[row, col] == arr[row + 1, col])
                                    {
                                        walk[++row, col] = 2; //up
                                        flag = true;
                                        counter++;
                                    }
                                }
                            }
                        }
                        //go back

                        if (walk[row, col] == 1) //try left
                        {
                            col--;
                            flag = true;
                        }
                        else if (walk[row, col] == 2) //try up
                        {
                            row--;
                            flag = true;
                        }
                        else if (walk[row, col] == 4) //try right
                        {
                            col++;
                            flag = true;
                        }
                        else if (walk[row, col] == 8) // try down
                        {
                            row++;
                            flag = true;
                        }

                        if ((walk[row, col] == 0xf) && (ruler == 0xf))
                        {
                            max = Math.Max(counter, max);
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}
