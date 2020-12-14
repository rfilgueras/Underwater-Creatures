using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CreaturesOfTheSea
{
    public class Item
    {
        public Item()
        {

        }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name;
        public string Description;

    }
}
