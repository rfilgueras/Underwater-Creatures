using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    class Whale : Creature
    {

        public Whale(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Communicate()
        {
            Utility.WriteText("MOOOOOAAAAAAANNNNNNNNNN");
        }

    }
}
