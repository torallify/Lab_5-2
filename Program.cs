using System;

namespace Lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock Paper Scissors!\n");

            Console.Write("Enter your name: ");
            string userInputName = Console.ReadLine();
            
            do
            {
                Console.Write("\nWho would you like to play against Randy or Rocky? ");
                string opponent = Console.ReadLine().ToLower();

                while (opponent != "randy" && opponent != "rocky")
                {
                    Console.WriteLine("Invalid entry please try again");
                    Console.Write("\nWho would you like to play against Randy or Rocky? ");
                    opponent = Console.ReadLine().ToLower();
                }

                HumanPlayer userPlayer = new HumanPlayer(userInputName);
                Roshambo userRoshambo = userPlayer.GenerateRoshambo();

                if (opponent == "randy")
                {
                    RandomPlayer randytest = new RandomPlayer();
                    Roshambo randyRoshambo = randytest.GenerateRoshambo();
                    Compete(userPlayer.Name, userRoshambo ,randytest.Name, randyRoshambo);

                }
                else if (opponent == "rocky")
                {
                    RockPlayer rocktest = new RockPlayer();

                    Roshambo rockRoshambo = rocktest.GenerateRoshambo();
                    Compete(userPlayer.Name, userRoshambo, rocktest.Name, rockRoshambo);
                }
            } while (UserContinue());

            Console.WriteLine("\nUntil next time!! Come back soon!! \n OKKKK BAIIIIIII!!!");
        }
        public static void Compete(string playerName1, Roshambo player1, string playerName2, Roshambo player2)
        {
            string finalResults = null;
            // Rock = 1, Paper = 2, Scissors = 3
            // Paper beats Rock || Scissors beats Paper || Paper beats Rock

            if (player1 == player2)
            {
                finalResults += "It's a tie!!!!";
            }
            else if ((player1 == (player2 - 1)) || (player1 == (player2 +2)))
            {
                finalResults += $"{playerName2} WINS!!!!";
            }
            else 
            {
                finalResults +=  $"{playerName1} WINS!!!";
            }
            Console.WriteLine($"\n{playerName1}: {player1.ToString()}");
            Console.WriteLine($"{playerName2}: {player2.ToString()}\n");
            Console.WriteLine(finalResults);
        }
        
        
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nPlay again? (y/n) ");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                if (key == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (key != 'y');
            return true;
        }
    }
}
