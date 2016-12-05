using System;
using System.Linq;

namespace PenguinAirlines
{
    class Startup
    {
        static bool direct;

        static bool CheckFlight(int from, int to, int[][] flights, bool[] islands)
        {
            bool result = false;
            bool working = false;
            foreach (var flight in flights[from])
            {
                if (flight == -1)
                {
                    return false;
                }
                if (!islands[flight])
                {
                    islands[flight] = true;
                    working = true;

                    if (to == flight)
                    {
                        return true;
                    }
                }
            }

            if (working)
            {
                direct = false;
                foreach (var flight in flights[from])
                {

                    bool sb = CheckFlight(flight, to, flights, islands);
                    if (sb)
                    {
                        return sb;
                    }
                }
            }

            return result;
        }

        static void Main()
        {
            int numN;
            if (!int.TryParse(Console.ReadLine(), out numN))
            {
                throw new Exception("Invalid Number N!");
            }

            string[] tmp = new string[numN];
            int[][] flights = new int[numN][];
            for (int i = 0; i < numN; i++)
            {
                tmp[i] = Console.ReadLine();
            }
            for (int i = 0; i < numN; i++)
            {
                if (tmp[i] == "None")
                {
                    flights[i] = new int[] { -1 };
                }
                else
                {
                    flights[i] = tmp[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                }
            }

            bool[] islands = new bool[numN];
            string[] islandToIsland = new string[2];
            string islandToInput = "";
            bool[,] answers = new bool[2, 10000];
            int counter = 0;
            do
            {
                islandToInput = Console.ReadLine();
                if (islandToInput != "Have a break")
                {
                    for (int j = 0; j < numN; j++)
                    {
                        islands[j] = false;
                    }
                    direct = true;
                    islandToIsland = islandToInput.Split(' ');
                    bool sb = CheckFlight(int.Parse(islandToIsland[0]), int.Parse(islandToIsland[1]), flights, islands);
                    answers[0, counter] = sb;
                    answers[1, counter] = direct;
                    counter++;
                }

            } while (islandToInput != "Have a break");
            for (int i = 0; i < counter; i++)
            {
                if (!answers[0, i])
                {
                    Console.WriteLine("No flights available.");
                }
                else if (answers[1, i])
                {
                    Console.WriteLine("There is a direct flight.");
                }
                else
                {
                    Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                }
            }
        }
    }
}

