using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    class RockPlayer : Player
    {
        
        public RockPlayer() : base("Rocky")
        {
            
        }

        public override Roshambo GenerateRoshambo()
        {
            roshamboValue = Roshambo.Rock;

            return roshamboValue;
        }
    }
}
