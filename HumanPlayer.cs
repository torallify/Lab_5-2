using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }
        public override Roshambo GenerateRoshambo()
        {
            string userChoice = null;

            Console.Write("\nPick rock, paper, or scissors: ");

            userChoice = Console.ReadLine().ToLower();
            
            while (userChoice != "rock" && userChoice == "paper" && userChoice == "scissors")
            {
                Console.WriteLine("Invalid input! Please try again!");

                Console.Write("\nPick rock, paper, or scissors: ");
                userChoice = Console.ReadLine();
            }

            
            if (userChoice == "rock")
            {
                roshamboValue = Roshambo.Rock;
                
            }
            else if (userChoice == "paper")
            {
                roshamboValue = Roshambo.Paper;
                
            }
            else if (userChoice == "scissors")
            {
                roshamboValue = Roshambo.Scissors;
            }

            return roshamboValue;
        }
    }
}
