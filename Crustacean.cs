using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    public class Crustacean : Creature
    {

        public int NumberOfLeg { get; set; }

        public Crustacean(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} is actually a walker.");
        }

        public override void Communicate()
        {
            Utility.WriteText("It counts its legs.");
        }

    }
}
