using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class AnimalFactory
    {
        public static Animal CreateAnimal(string type, string name)
        {
            switch (type)
            {
                case "Bird": return new Bird(name);
                case "Dog": return new Dog(name);
                case "Cat": return new Cat(name);
                case "Fish": return new Fish(name);
                case "Horse": return new Horse(name);
                default: throw new ArgumentException("Unknown animal type");
            }
        }
    }
}
