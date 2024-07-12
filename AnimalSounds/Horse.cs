using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalSounds
{
    public class Horse : Animal
    {
        public Horse(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound: neigh");
        }
    }
}
