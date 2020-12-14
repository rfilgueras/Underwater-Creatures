using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreaturesOfTheSea
{
    static class Game
    {
        public static void Start()
        {

            //lil guys
            Fish betaFish = new Fish("Fruit Loop", "Beta");
            Crustacean crab = new Crustacean("Eugene Krabs", "Crab");
            Turtle turtle = new Turtle("Tamatoa", "Sea Turtle");
            SeaHorse seaHorse = new SeaHorse("Curly Boy", "Sea Horse");
            Whale whale = new Whale("Sad Boy", "Blue Whale");
            Shark shark = new Shark("Pointy Boy", "White Shark");


            //food
            Food fishFood = new Food() {Name = "Fishy Flakes"};
            Food plankton = new Food() { Name = "Evil Plankton" };
            Food worm = new Food() { Name = "Jerry the Worm" };

            //items
            Item boot = new Item() { Name = "Nasty Boot" };
            Item straw = new Item() { Name = "Starbucks Venti Straw" };
            Item randomTrash = new Item() { Name = "Discarded Mask" };

            List<Item> items = new List<Item>();
            items.Add(fishFood);
            items.Add(plankton);
            items.Add(worm);
            items.Add(boot);
            items.Add(straw);
            items.Add(randomTrash);

            List<Creature> creatures = new List<Creature>();
            creatures.Add(betaFish);
            creatures.Add(crab);
            creatures.Add(seaHorse);
            creatures.Add(whale);
            creatures.Add(shark);
            creatures.Add(turtle);


            

            Player player = new Player();

            Utility.WriteText("Hi, there!");

            player.Name = Utility.GetUserInput("what is your name");
            Utility.WriteText($"Welcome to the Ocean, {player.Name}!");

            Creature chosenCreature = player.Choose(creatures);

            List<string> options = new List<string>();
            options.Add("Feed Fish");
            options.Add("Communicate with Fish");
            options.Add("Choose another Fish");
            options.Add("Stop Swimming and Get Out Of The Ocean");


            bool exit = false;

            while (!exit)
            {
                int userActionChoice = Utility.ShowMenu("What do you want to do? ", options);
                switch (userActionChoice)
                {
                    case 1:
                        chosenCreature.Eat(items);
                        break;
                    case 2:
                        chosenCreature.Communicate();
                        break;
                    case 3:
                        chosenCreature = player.Choose(creatures);
                        break;
                    case 4:
                        exit = true;
                        Utility.WriteText("Thanks for swimming!  All of the fishes wave goodbye.", ConsoleColor.Yellow);
                        break;
                    default:
                        break;
                }
            }

            









        }

    }
}
