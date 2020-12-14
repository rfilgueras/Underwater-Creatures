using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    public class ClownFish : Fish
    {
        public bool HasStripes { get; set; }

        public bool IsToxic { get; set; }

        public ClownFish(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }
    }
}
