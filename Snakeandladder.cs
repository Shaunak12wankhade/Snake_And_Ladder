using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    class Snakeandladder
    {
        static void Main(string[] args)
        {
          
            {
                Random random = new Random();
                int diceRoll = random.Next(1, 6);
                Console.WriteLine("You got " + diceRoll);
                //Constants
                const int samePosition = 0;
                const int forward = 1;
                Random random1 = new Random();
                int options = random1.Next(0, 2);
                if (options == samePosition)
                {
                    Console.WriteLine("You Got No Option Stay in the Same Place.");
                }
                else if (options == forward)
                {
                    Console.WriteLine("You Got Ladder Your moving ahead by " + diceRoll + " numbers.");
                }
                else
                    Console.WriteLine("You Got Snake Your Moving Backward by " + diceRoll + " numbers.");
            }

        }
    }
}
