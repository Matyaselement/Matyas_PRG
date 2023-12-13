using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int maxage;

            public virtual void MakeNoise()
            {
                Console.WriteLine("*animal noises*");
            }
        }

        class Dog : Animal
        {
            public string race;

            public override void MakeNoise()
            {
                Console.WriteLine("Woof Woof Woooof");
            }
        }

        class Cat : Animal
        {
            public string furcolor;
        }

        class Mammal : Animal
        {
            public string pregtime;         
        }
    static void Main(string[] args)
    {
        Animal newAnimal = new Animal();
        newAnimal.MakeNoise();

        Dog newDog = new Dog();
        newDog.name = "Fido";
        newDog.maxage = 14;
        newDog.race = "Laika";
        //newDog.pregtime = "idk lol";
        Console.WriteLine($"{newDog.name} is {newDog.maxage} years old and is {newDog.race}");
        newDog.MakeNoise();

            Cat newCat = new Cat();
            newCat.name = "Micka";
            newCat.maxage = 23;
            newCat.furcolor = "silver";
            Console.WriteLine($"{newCat.name} is {newCat.maxage} years old and has {newCat.furcolor} fur");

            Console.ReadKey();
        }
    }
}
