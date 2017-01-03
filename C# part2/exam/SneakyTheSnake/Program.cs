using System;

namespace SneakyTheSnake
{
    class Program
    {
        static void PrintMyMatrix(char[,] den)
        {
            for (int i = 0; i < den.GetLength(0); i++)
            {
                for (int j = 0; j < den.GetLength(1); j++)
                {
                    Console.Write("{0}", den[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            string[] dim = Console.ReadLine().Split('x');
            char[,] den = new char[int.Parse(dim[0]), int.Parse(dim[1])];
            int currentY = 0, startX = 0, startY = 0;
            for (int i = 0; i < den.GetLength(0); i++)
            {
                string inputRow = Console.ReadLine();

                for (int j = 0; j < den.GetLength(1); j++)
                {
                    if (inputRow[j] == 'e')
                    {
                        currentY = j;
                        startX = i;
                        startY = j;

                    }
                    den[i, j] = inputRow[j];
                }
            }
            //PrintMyMatrix(den);
            string input = Console.ReadLine();
            char[] directions = new char[input.Length / 2 + 1];
            int counter = 0;
            foreach (var ch in input)
            {
                if (Char.IsLetter(ch))
                {
                    directions[counter++] = ch;
                }

            }

            int sneakyLen = 3;
            int currentX = 0;
            int stepCounter = 0;
            bool isItAlive = true;
            for (int move = 0; move < directions.Length; move++)
            {
                if (directions[move] == 's')
                {
                    currentX++;
                    if (currentX == den.GetLength(0))
                    {
                        Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", sneakyLen);
                        isItAlive = false;
                        break;
                    }
                }
                else if (directions[move] == 'w')
                {
                    currentX--;
                    if (currentX < 0)
                    {
                        Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", sneakyLen);
                        isItAlive = false;
                        break;
                    }
                }
                else if (directions[move] == 'a')
                {
                    currentY--;
                    if (currentY < 0)
                    {
                        currentY = den.GetLength(1) - 1;
                    }
                }
                else if (directions[move] == 'd')
                {
                    currentY++;
                    if (currentY == den.GetLength(1))
                    {
                        currentY = 0;
                    }
                }

                stepCounter++;
                if (den[currentX, currentY] == '@')
                {
                    sneakyLen++;
                    den[currentX, currentY] = '-';
                }


                if (stepCounter == 5)
                {
                    sneakyLen--;
                    stepCounter = 0;
                    if (sneakyLen == 0)
                    {
                        Console.WriteLine("Sneaky is going to starve at [{0},{1}]", currentX, currentY);
                        isItAlive = false;
                        break;
                    }
                }


                if (sneakyLen == 0)
                {
                    Console.WriteLine("Sneaky is going to starve at [{0},{1}]", currentX, currentY);
                    isItAlive = false;
                    break;
                }
                else if (currentX == startX && currentY == startY)
                {
                    Console.WriteLine("Sneaky is going to get out with length {0}", sneakyLen);
                    isItAlive = false;
                    break;
                }
                else if (den[currentX, currentY] == '%')
                {
                    Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentX, currentY);
                    isItAlive = false;
                    break;
                }
            }
            if (isItAlive)
            {
                Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", currentX, currentY);
            }
        }
    }
}
