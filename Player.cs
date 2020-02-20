using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    abstract class Player
    {
        protected string name;
        protected Roshambo roshamboValue;

        public string Name { get => name; set => name = value; }
        public Roshambo RoshamboValue { get => roshamboValue; set => roshamboValue = value; }
       

        public Player(string name)
        {
            this.name = name;
        }
        public abstract Roshambo GenerateRoshambo();

    }
}
