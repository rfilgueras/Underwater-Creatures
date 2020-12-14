using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreaturesOfTheSea
{
    public class Creature
    {

        public string Name { get; set; }

        public string CreatureType { get; set; }

        public double Size { get; set; }

        public double Weight { get; set; }

        public bool IsHungry = true;

        public int EatCount = 0;

        public Creature()
        {

        }

        public Creature(string name, string creatureType)
        {
            Name = name;
            CreatureType = creatureType;
        }

        public Creature(string name, string creatureType, double size, double weight)
        {
            Name = name;
            CreatureType = creatureType;
            Size = size;
            Weight = weight;
        }

        public virtual void Swim()
        {
            Console.WriteLine($"{Name} is swiming");
        }



        /// <summary>
        /// this method accepts an item list and then checks to see if it is a food, then flipping the hunger to false if successful.  if it fails, it recursively calls itself.  this method will automatically stop after ten attempts if the list contains no food items.
        /// </summary>
        /// <param name="items">a list of items that contains at least one food.</param>
        public void Eat(List<Item> items)
        {
            EatCount++;
            Random rnd = new Random();
            int itemChoice = rnd.Next(items.Count);
            Item userChoice = items[itemChoice];

            if (userChoice is Food)
            {
                Utility.WriteText($"{Name} eats {userChoice.Name}.  He seems very happy about it.");
                IsHungry = false;
                Utility.WriteText($"{Name} isn't hungry anymore.");
            }
            else
            {
                Utility.WriteText($"{Name} didn't like that very much. {userChoice.Name} is not a food.", ConsoleColor.Red);
                Utility.WriteText($"{Name} is still hungry.");

                if (EatCount <= 10)
                {
                    Eat(items);
                }

            }
        }

        public virtual void Communicate()
        {
            Utility.WriteText("The fish blubs, but it really just wants food.");
        }

    }
}
