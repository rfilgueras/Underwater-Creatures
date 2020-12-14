using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Console;

namespace CreaturesOfTheSea
{
    public static class Utility
    {
        //this class is where we put useful repeated commands.

        //this method helps us get user input, wherever applicable.
        public static string GetUserInput(string Title)
        {
            string userInput;
            WriteText(Title);
            userInput = ReadLine();
            userInput = userInput.Trim();

            //this runs if the player inputs nothing.
            while (String.IsNullOrEmpty(userInput))
            {
                WriteLine("Please enter a value.");
                userInput = ReadLine();
                userInput = userInput.Trim();
            }
            return userInput;
        }

        //this method helps us get user input, wherever applicable and converts it to a string. By default the return value is -1 to check if a valid user input has been parsed
        public static int GetUserInputInt(string Title)
        {
            int result = -1;
            string userInput;
            WriteLine(Title);
            userInput = ReadLine();
            userInput = userInput.Trim();

            //this runs if the player inputs nothing.
            while (String.IsNullOrEmpty(userInput))
            {
                WriteLine("Please enter a value.");
                userInput = ReadLine();
                userInput = userInput.Trim();
            }
            int.TryParse(userInput, out result);
            return result;
        }

        //this method helps the user answer yes or no questions.
        public static bool Affirm(string Title)
        {
            WriteLine(Title);
            while (true)
            {
                ConsoleKey UserInput = ReadKey().Key;
                switch (UserInput)
                {
                    case ConsoleKey.N:
                        return false;
                    case ConsoleKey.Y:
                        return true;
                    default:
                        WriteLine("Please press Y/N to affirm or deny.");
                        break;
                }
            }
        }

        //this method creates the lines at the top of the screen!
        public static void Line()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Write("-");
            }
            Write("\n");
        }

        //this method centers the text at the top of the screen
        public static void Center(string input)
        {
            int half = WindowWidth / 2;
            half = half - (input.Length / 2);
            if (half > 0)
            {
                for (int i = 0; i < half; i++)
                {
                    Write(" ");
                }
                Write(input);
            }
            else
            {
                Write(input);
            }
            Write("\n");
        }


        public static void WriteText(string text, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }

        /// <summary>
        /// this method gets the user input integer and compares it to the range of a given list.
        /// </summary>
        /// <param name="range"> the range is the max number that a player is able to choose from.  </param>
        /// <returns></returns>
        public static int GetUserInputRange(int range)
        {
            int result = -1;
            string userInput;
            userInput = ReadLine();
            userInput = userInput.Trim();

            //this runs if the player inputs nothing.
            while (String.IsNullOrEmpty(userInput))
            {
                WriteLine("Please enter a value.");
                userInput = ReadLine();
                userInput = userInput.Trim();
            }
            int.TryParse(userInput, out result);

            if (result < 1 || result > range)
            {
                WriteText($"Please enter a number between 1 and {range}.");
                result = GetUserInputRange(range);
            }

            return result;
        }

        public static int ShowMenu(string title, List<string> options)
        {
            Utility.WriteText(title);

            int index = 1;
            foreach (var option in options)
            {
                Utility.WriteText($"{index}) {option}", ConsoleColor.Green);
                index++;
            }

            int choice = Utility.GetUserInputRange(options.Count);

            return choice;
        }



    }
}
