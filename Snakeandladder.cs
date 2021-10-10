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
            Snakeandladder.twoplayers();
            Console.ReadLine();
        }


        //Constants
        public const int maxPosition = 100;
        public const int samePosition = 0;
        public const int forward = 1;
        public const int backward = 2;
        public static void twoplayers()
        {
            Console.WriteLine("");             

            //Variables
            int player1Position = 0;
            int player2Position = 0;
            int newPositionPlayer1 = 0;
            int newPositionPlayer2 = 0;
            int noofdiceroll = 0;

            //Computation
            while (player1Position <= maxPosition && player2Position <= maxPosition)
            {
                //Random numbers generation
                Random random = new Random();
                int dice1 = random.Next(1, 6);
                int dice2 = random.Next(1, 6);
                int options1 = random.Next(0, 3);
                int options2 = random.Next(0, 3);

                Console.WriteLine("Player 1 got " + dice1);
                Console.WriteLine("Player 2 got " + dice2);



                newPositionPlayer1 = player1Position + dice1;
                newPositionPlayer2 = player2Position + dice2;
                noofdiceroll++;


                if (newPositionPlayer1 == maxPosition)
                {
                    Console.WriteLine("Player 1 won the Game :)");
                    Console.WriteLine("Dice rolled " + noofdiceroll);
                    break;
                }

                else if (newPositionPlayer1 > maxPosition)
                {
                    Console.WriteLine("Player 1 got No option so stay");
                    Console.WriteLine("Player 2 current Position is: " + player1Position);
                    Console.WriteLine("");                    
                    continue;
                }

                if (newPositionPlayer2 == maxPosition)
                {
                    Console.WriteLine("Player 2 won the Game :)");
                    Console.WriteLine("Dice rolled " + noofdiceroll);
                    break;
                }

                else if (newPositionPlayer2 > maxPosition)
                {
                    Console.WriteLine("Player 2 got No option so stay");
                    Console.WriteLine("Player 2 current Position is: " + player2Position);
                    Console.WriteLine("-------------------------------------");                     
                    continue;
                }

                //For Player 1
                if (options1 == samePosition)
                {
                    Console.WriteLine("Player 1 got No option so Stay");
                }
                else if (options1 == forward)
                {
                    player1Position += dice1;
                    Console.WriteLine("Player 1 got ladder so move forward " + dice1);
                }
                else if (options1 == backward)
                {
                    player1Position -= dice1;
                    Console.WriteLine("Player 1 got snake so move backward " + dice1);
                }

                //For Player 2
                if (options2 == samePosition)
                {
                    Console.WriteLine("Player 2 got No option so Stay");
                }
                else if (options2 == forward)
                {
                    player2Position += dice2;
                    Console.WriteLine("Player 2 got ladder so move forward" + dice2);
                }
                else if (options2 == backward)
                {
                    player2Position -= dice2;
                    Console.WriteLine("Player 2 got snake so move backward " + dice2);
                }

                if (player1Position <= 0)
                {
                    Console.WriteLine("Player 1 lost so restart further");
                    player1Position = player1Position - player1Position;
                }
                if (player2Position <= 0)
                {
                    Console.WriteLine("Player 2 lost so restart further");
                    player2Position = player2Position - player2Position;
                }
                Console.WriteLine("Player 1 current Position is: " + player1Position);
                Console.WriteLine("Player 2 current Position is: " + player2Position);
                Console.WriteLine("Dice rolled " + noofdiceroll);
                Console.WriteLine("");                 //For separation
            }
        }
        
        
    }
}
