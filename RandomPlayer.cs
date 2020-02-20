using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    class RandomPlayer : Player
    {
        protected static Random random;

        
        public RandomPlayer() : base("Randy")
        {
             
            if (random == null)
            {
                random = new Random();
            }
        }
        

        public override Roshambo GenerateRoshambo()
        {
            roshamboValue = (Roshambo)random.Next(1, 4);

            return roshamboValue;
        }
    }
}
