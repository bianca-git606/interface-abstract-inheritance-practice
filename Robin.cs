using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    internal class Robin : Animal
    {
        public Robin(int weight, bool isAlive, string name) : base(weight, isAlive, name)
        {

        }
        new public void Sing()
        {
            Console.WriteLine("Chirp chirp");
        }

    }
}
