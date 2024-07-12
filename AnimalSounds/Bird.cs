using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Bird: Animal
    {
        public Bird(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound: chirp");
        }
    }
}
