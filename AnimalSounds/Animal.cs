using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public interface IAnimal
    {
        string Name { get; }
        void MakeSound();
    }

    public abstract class Animal : IAnimal {
        public string Name { get; protected set; }
        public abstract void MakeSound();
    }
}
