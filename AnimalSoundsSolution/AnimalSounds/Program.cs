using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Monkey monkey = new Monkey();
            Cat cat = new Cat();
            Duck duck = new Duck();
            Cow cow = new Cow();
            Lion lion = new Lion();
            Snake snake = new Snake();
            Donkey donkey = new Donkey();
            Bird bird = new Bird();
            Trumpet trumpet = new Trumpet();




            IAnimalSounds[] animals = // an array (collection) built on the interface commonality
            {
                dog, monkey, cat, duck, cow, lion, snake, donkey, bird, trumpet
            };

            foreach (IAnimalSounds animal in animals)
            {
                string animalName = animal.GetAnimalName();
                string animalSound = animal.GetAnimalSound();


                string message = $"A(n) {animalName} says {animalSound}."; // shortcut concatination (interpolation)
                Console.WriteLine(message);

            }
            Console.ReadLine();

        }
    }
}
