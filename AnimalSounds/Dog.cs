using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound: bark");
        }
    }
}
