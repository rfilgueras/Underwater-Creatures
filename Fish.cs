using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    public class Fish : Creature
    {
        public bool FunctionalGills{ get; set; }

        public bool HasScales { get; set; }

        public Habitat FishHabitat { get; set; }

        public Fish()
        {

        }

        public Fish(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public override void Swim()
        {
            Console.WriteLine($"My fish {Name} is swiming");
        }

        public override void Communicate()
        {
            Utility.WriteText("It stares into your soul, pulling your secrets out of your gaze.  \nThe only thing it desires are fish food and all of your secrets.");
        }
    }
}
