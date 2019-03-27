using System;

namespace LotteryGame
{
    class Program
    {

        private static int bankAccount = 25;  //global variables for the main program

        private static char press = ' ';

        private static bool playAgain;



        static void Main(string[] args)

        {

            Lottery nationalLottery = new Lottery();



            do

            {

                nationalLottery.SelectNumbers();

                Console.WriteLine();



                Console.WriteLine("Press any key to continue.");

                Console.WriteLine();

                press = Console.ReadKey(true).KeyChar;



                nationalLottery.Play(ref bankAccount);

                Console.WriteLine();



                nationalLottery.YouWon(ref bankAccount);

                Console.WriteLine();



                playAgain = nationalLottery.PlayAgain();



                if (playAgain == true)

                {

                    playAgain = nationalLottery.CheckBalance(ref bankAccount);

                }

                else

                {

                    Console.WriteLine("Maybe another time.");

                    Console.WriteLine();

                }



            } while (playAgain);

        }

    }
}
