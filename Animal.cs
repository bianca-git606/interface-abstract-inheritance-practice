using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    abstract public class Animal
    {
        Boolean isAlive;
        public int Weight { get; set; }
        public string Name { get; set; }
        public Animal() 
        {
            Console.WriteLine("Animal constructor");
        }
        public Animal(int weight, bool alive, string name)
        {
            Weight = weight;
            isAlive = alive;
            Name = name;
        }
        public void Greet() 
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal is talking.");
        }
        public void Sing() 
        {
            Console.WriteLine("The animal is singing");
        }
        override public string ToString()
        {
            return "Status: " + isAlive + "\tWeight: " + Weight;
        }
    }
}
