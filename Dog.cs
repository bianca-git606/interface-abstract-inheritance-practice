using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    public class Dog : Animal, IDomesticated
    {
        public Dog(int weight, bool alive, string name) : base(weight, alive, name)
        {

        }

        public void FeedMe()
        {
            Console.WriteLine("Yeyy! Treats!!");
        }

         new public void Talk()
        {
            Console.WriteLine("Bark bark ");
        }

        public void TouchMe()
        {
            Console.WriteLine("Pwease scratch my tummy.");
        }
    }
}
