using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    class Turtle : Creature
    {
        public Turtle(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Communicate()
        {
            Utility.WriteText("*turtle noise*");
        }

    }
}
