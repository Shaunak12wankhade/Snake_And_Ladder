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
            Snakeandladder.exactposition100();
            Console.ReadLine();
        }
       

            //Constants
        public const int maxposition = 100;
        public const int sameposition = 0;
        public const int forward = 1;
        public const int backward = 2;
        public static void exactposition100()
        {
            Console.WriteLine("");

            //variables
            int currentposition = 1;
            int newposition = 1;

            while (currentposition <= maxposition)
            {
                Random random = new Random();
                int dice = random.Next(1, 6);
                Console.WriteLine("You got" + dice);

                Random random1 = new Random();
                int options = random1.Next(0, 3);

                newposition = currentposition + dice;

                if (newposition == 100)
                {
                    currentposition = currentposition - dice;
                    Console.WriteLine("You won");
                    break;
                }
                else if (newposition > 100)
                {
                    Console.WriteLine("You got No option so stay");
                    Console.WriteLine("Your current position is: " + currentposition);
                    Console.WriteLine("");
                    continue;

                }

                if (options == sameposition)
                {
                    Console.WriteLine("You got no option so stay");
                }
                else if (options == forward)
                {
                    currentposition = currentposition + dice;
                    Console.WriteLine("You got ladder so move forward" + dice);
                }
                else if (options == backward)
                {
                    currentposition = currentposition - dice;
                    Console.WriteLine("You got snake so move backward" + dice);
                }
                if (currentposition >= 100)
                {
                    Console.WriteLine("You won");
                    break;
                }

                
                else if (currentposition <= 0)
                {
                    Console.WriteLine("You Lost so restart further");
                    currentposition = currentposition - currentposition;
                }
                Console.WriteLine("Your current position is : " + currentposition);
                Console.WriteLine("");
            }


        }
        
    }
}
