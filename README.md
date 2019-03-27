"# LotteryGame" 

using System;



namespace Lottery

{

    class Program

    {

        private static int bankAccount = 25;  //global variables for the main program

        private static char press = ' ';

        private static bool playAgain;



        static void Main(string[] args)

        {

            LotteryGame nationalLottery = new LotteryGame();



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



    class LotteryGame

    {

        private static int money;     // global variables for the LotteryGame class

        private static int no1;

        private static int no2;

        private static int no3;

        private static int no4;

        private static int no5;

        private static int no6;      // numbers representing the user choice



        private static int lotNo1;

        private static int lotNo2;

        private static int lotNo3;

        private static int lotNo4;

        private static int lotNo5;

        private static int lotNo6;   // numbers representing the extracted numbers



        private static int match = 0;



        private static int winMoney = 0;



        private static char yes = 'y';

        private static char no = 'n';





        public void Play(ref int money) // the Play method that generates the numbers

        {

            money -= 5; // every time it's called, money will be decrementated with 5



            Random Lottery = new Random();

            lotNo1 = Lottery.Next(1, 50);



            do

            {

                lotNo2 = Lottery.Next(1, 50);

            } while (lotNo2 == lotNo1);



            do

            {

                lotNo3 = Lottery.Next(1, 50);

            } while ((lotNo3 == lotNo1) || (lotNo3 == lotNo2));



            do

            {

                lotNo4 = Lottery.Next(1, 50);

            } while ((lotNo4 == lotNo3) || (lotNo4 == lotNo2) || (lotNo4 == lotNo1));



            do

            {

                lotNo5 = Lottery.Next(1, 50);

            } while ((lotNo5 == lotNo4) || (lotNo5 == lotNo3) || (lotNo5 == lotNo2) || (lotNo5 == lotNo1));



            do

            {

                lotNo6 = Lottery.Next(1, 50);

            } while ((lotNo6 == lotNo5) || (lotNo6 == lotNo4) || (lotNo6 == lotNo3) || (lotNo6 == lotNo2) || (lotNo6 == lotNo1));



            Console.WriteLine($"The numbers extracted are: {lotNo1}, {lotNo2}, {lotNo3}, {lotNo4}, {lotNo5}, {lotNo6}.");

        }



        public void SelectNumbers() // the SelectNumbers method get's the user choices

        {

            Console.WriteLine("Select the numbers you want to play from 1 to 49.");



            Console.Write("Number one: ");

            no1 = Convert.ToInt32(Console.ReadLine());

            if ((no1 < 1) || (no1 > 49))

            {

                Console.WriteLine("Select a number between 1 and 49.");

                no1 = Convert.ToInt32(Console.ReadLine());

            }



            do

            {

                Console.Write("Number two: ");

                no2 = Convert.ToInt32(Console.ReadLine());

                if ((no2 < 1) || (no2 > 49))

                {

                    Console.WriteLine("Select a number between 1 and 49.");

                    no2 = Convert.ToInt32(Console.ReadLine());

                }

            } while (no2 == no1);



            do

            {

                Console.Write("Number three: ");

                no3 = Convert.ToInt32(Console.ReadLine());

                if ((no3 < 1) || (no3 > 49))

                {

                    Console.WriteLine("Select a number between 1 and 49.");

                    no3 = Convert.ToInt32(Console.ReadLine());

                }

            } while ((no3 == no2) || (no3 == no1));



            do

            {

                Console.Write("Number four: ");

                no4 = Convert.ToInt32(Console.ReadLine());

                if ((no4 < 1) || (no4 > 49))

                {

                    Console.WriteLine("Select a number between 1 and 49.");

                    no4 = Convert.ToInt32(Console.ReadLine());

                }

            } while ((no4 == no3) || (no4 == no2) || (no4 == no1));



            do

            {

                Console.Write("Number five: ");

                no5 = Convert.ToInt32(Console.ReadLine());

                if ((no5 < 1) || (no5 > 49))

                {

                    Console.WriteLine("Select a number between 1 and 49.");

                    no5 = Convert.ToInt32(Console.ReadLine());

                }

            } while ((no5 == no4) || (no5 == no3) || (no5 == no2) || (no5 == no1));



            do

            {

                Console.Write("Number six: ");

                no6 = Convert.ToInt32(Console.ReadLine());

                if ((no6 < 1) || (no6 > 49))

                {

                    Console.WriteLine("Select a number between 1 and 49.");

                    no6 = Convert.ToInt32(Console.ReadLine());

                }

            } while ((no6 == no5) || (no6 == no4) || (no6 == no3) || (no6 == no2) || (no6 == no1));



            Console.WriteLine($"The numbers selected for play are: {no1}, {no2}, {no3}, {no4}, {no5}, {no6}.");

            Console.WriteLine("Good Luck!");

        }



        public void YouWon(ref int money) // YouWon will compare the numbers to see if the user matched one or more

        {                         // numbers, the match variable will increment every time the user matches a number

            if ((no1 == lotNo1) || (no1 == lotNo2) || (no1 == lotNo3) || (no1 == lotNo4) || (no1 == lotNo5) || (no1 == lotNo6))

            {

                match++;

            }

            if ((no2 == lotNo1) || (no2 == lotNo2) || (no2 == lotNo3) || (no2 == lotNo4) || (no2 == lotNo5) || (no2 == lotNo6))

            {

                match++;

            }

            if ((no3 == lotNo1) || (no3 == lotNo2) || (no3 == lotNo3) || (no3 == lotNo4) || (no3 == lotNo5) || (no3 == lotNo6))

            {

                match++;

            }

            if ((no4 == lotNo1) || (no4 == lotNo2) || (no4 == lotNo3) || (no4 == lotNo4) || (no4 == lotNo5) || (no4 == lotNo6))

            {

                match++;

            }

            if ((no5 == lotNo1) || (no5 == lotNo2) || (no5 == lotNo3) || (no5 == lotNo4) || (no5 == lotNo5) || (no5 == lotNo6))

            {

                match++;

            }

            if ((no6 == lotNo1) || (no6 == lotNo2) || (no6 == lotNo3) || (no6 == lotNo4) || (no6 == lotNo5) || (no6 == lotNo6))

            {

                match++;

            }

            // there's a different sum of money for every level of matching (match => 3)

            if (match == 1)
            {
                Console.WriteLine("You matched just 1 number. Try Again!");
                Console.WriteLine();
            }
            else if (match == 2)
            {
                Console.WriteLine("You matched just 2 numbers. Try Again!");
                Console.WriteLine();
            }
            else if (match == 3)

            {

                winMoney += 500;



                Console.WriteLine($"Congratulations you matched 3 numbers and won: {winMoney} euro");



                money += winMoney;



                Console.WriteLine($"Your account looks like this now: {money} euro");

            }



            else if (match == 4)

            {

                winMoney += 2500;



                Console.WriteLine($"Congratulations you matched 4 numbers and won: {winMoney} euro");



                money += winMoney;



                Console.WriteLine($"Your account looks like this now: {money} euro");

            }



            else if (match == 5)

            {

                winMoney += 100000;



                Console.WriteLine($"Congratulations you matched 5 numbers and won: {winMoney} euro");



                money += winMoney;



                Console.WriteLine($"Your account looks like this now: {money} euro");

            }



            else if (match == 6)

            {

                winMoney += 2500000;



                Console.WriteLine($"Congratulations you matched all the numbers and won the Big Price: {winMoney} euro");



                money += winMoney;



                Console.WriteLine($"Your account looks like this now: {money} euro");

                Console.WriteLine("You're a millionaire!");



            }

            else

            {

                Console.WriteLine("You have not matched even 1 number.");

            }



            Console.WriteLine($"Bank account: {money}");

            match = 0;

        }



        public bool PlayAgain() // the method PlayAgain will ask you at the end of every game to play again

        {

            char answer;

            while (true)

            {

                Console.WriteLine("Would you like to play again?");

                Console.WriteLine();



                answer = Console.ReadKey(true).KeyChar;

                answer = char.ToLower(answer);



                if (answer.Equals(yes))

                {

                    Console.WriteLine("Yes!");

                    Console.WriteLine();

                    return true;

                }

                else if (answer.Equals(no))

                {

                    Console.WriteLine("No!");

                    Console.WriteLine();

                    return false;

                }

                else

                {

                    Console.WriteLine("Select yes or no.");

                }

            }

        }



        public bool CheckBalance(ref int money) // after you chose to play again, the CheckBalance method will

        {                                      // check if you have enough money to play, if not, the program ends

            if (money < 5)

            {

                Console.WriteLine($"You don't have enough money to play! \n Bank account: {money}");

                Console.WriteLine();

                return false;

            }

            else

            {

                return true;

            }

        }

    }

}
