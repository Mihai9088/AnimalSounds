using System;
using AnimalSounds;

class Program
{
    static void Main(string[] args)
    {
        var animals = new List<IAnimal>
        {
            AnimalFactory.CreateAnimal("Bird", "Parrot"),
            AnimalFactory.CreateAnimal("Dog", "Beagle"),
            AnimalFactory.CreateAnimal("Cat", "Siamese"),
            AnimalFactory.CreateAnimal("Fish", "Goldfish"),
            AnimalFactory.CreateAnimal("Horse", "Stallion")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}