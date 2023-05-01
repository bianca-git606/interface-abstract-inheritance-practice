using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    internal class Goat : Animal, IMilkable
    {
        string Name { get; set; }
        string Type = "goat";
        public Goat(int weight, bool isAlive, string name) : base(weight, isAlive, name)
        {
            Name = name;
        }

        public void MilkMe()
        {
            Console.WriteLine("You're milking " + Name + "\nYou got a " + Type + " milk!");
        }
    }
}
