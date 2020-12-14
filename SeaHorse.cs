using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    class SeaHorse : Creature
    {

        public SeaHorse(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Communicate()
        {
            Utility.WriteText("It darts back and forth, neighing angrily.");
        }
    }
}
