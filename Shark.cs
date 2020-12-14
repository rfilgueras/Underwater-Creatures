using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    class Shark : Creature
    {

        public Shark(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Communicate()
        {
            Utility.WriteText("The shark stares at the bucket in your hand intently.");
        }
    }
}
