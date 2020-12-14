using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using static System.Console;


namespace CreaturesOfTheSea
{
    class Player
    {
        public string Name;
        public int Score;

        public Player()
        {

        }

        public Creature Choose(List<Creature> creatures)
        {
            //Utility.WriteText("Which creature would you like to interact with?");

            //int index = 1;
            //foreach (var boy in creatures)
            //{
            //    Utility.WriteText($"{index}) {boy.Name}", ConsoleColor.Green);
            //    index++;
            //}
            //int choice = Utility.GetUserInputRange(creatures.Count);

            //using LINQ to select Names from creatures list.
            List<string> options = creatures.Select(creature => creature.Name).ToList();
            int choice = Utility.ShowMenu("Which creature would you like to interact with?", options);  

            Creature selectedCreature = creatures[choice - 1];
            Utility.WriteText($"You have chosen {selectedCreature.Name}.  It swims up to you.");

            return selectedCreature;

        }
    }
}
