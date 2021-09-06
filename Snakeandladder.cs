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
            // UC2 Player rolls a die
            Random random = new Random();
            int dieRoll = random.Next(0, 7);
            Console.WriteLine("You got " + dieRoll + " in die roll.");
        }
    }
}
