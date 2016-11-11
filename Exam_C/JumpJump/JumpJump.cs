using System;

class JumpJump
{
    static void Main()
    {
        string instructions = Console.ReadLine();
        int i = 0;
        bool flag = true;
        
        while (flag)
        {
            if (instructions[i] != '^')
            {
                int numP = int.Parse(instructions[i].ToString());
                if (numP == 0) //zero
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    flag = false;
                }
                else if (numP % 2 == 0) //even
                {
                    i += numP;
                }
                else if (numP % 2 != 0) //odd
                {
                    i -= numP;
                }
                if (i >= instructions.Length || i < 0) //out
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", i);
                    flag = false;
                }
            }
            else // ^
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                flag = false;
            }
        }
    }
}
