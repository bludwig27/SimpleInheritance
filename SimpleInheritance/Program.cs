using System;
using System.Drawing;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}.");
        }

    }

    class Pangolin : Animal
    {
        public string food;
        public string biome;
        public string color;

        public Pangolin() : base()
        {
            name = "Pangy";
            food = "ants";
            biome = "savanna";
            color = "brown";
        }

        public Pangolin(string name, string food, string biome, string color) : base(name)
        {
            this.food = food;
            this.biome = biome;
            this.color = color;
        }

        public void getName()
        {
            Console.WriteLine();
            Console.WriteLine($"I am a pangolin! My name is {name}.");
        }
        public void getFood()
        {
            Console.WriteLine($"I like to eat {food}!");
        }
        public void getBiome()
        {
            Console.WriteLine($"I live in the {biome}.");
        }
        public void getColor()
        {
            Console.WriteLine($"My main color is {color}.");
        }
    }

    class Armadillo : Animal
    {
        public string food;
        public string biome;
        public string weight;

        public Armadillo() : base()
        {
            name = "Amy";
            food = "bugs";
            biome = "desert";
            weight = "15 pounds";
        }

        public Armadillo(string name, string food, string biome, string weight) : base(name)
        {
            this.food = food;
            this.biome = biome;
            this.weight = weight;
        }

        public void getName()
        {
            Console.WriteLine();
            Console.WriteLine($"I am an armadillo! My name is {name}.");
        }
        public void getFood()
        {
            Console.WriteLine($"I like to eat {food}!");
        }
        public void getBiome()
        {
            Console.WriteLine($"I live in the {biome}.");
        }
        public void getWeight()
        {
            Console.WriteLine($"I weigh about {weight}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Pangolin myPang = new Pangolin();
            myPang.getName();
            myPang.getFood();
            myPang.getBiome();
            myPang.getColor();

            //derived class object using parameterized constructor
            Pangolin myPang2 = new Pangolin("Pango","army ants","woodlands","golden");
            myPang2.getName();
            myPang2.getFood();
            myPang2.getBiome();
            myPang2.getColor();

            Armadillo myArma= new Armadillo();
            myArma.getName();
            myArma.getFood();
            myArma.getBiome();
            myArma.getWeight();

            Armadillo myArma2= new Armadillo("Arthur","grubs","plains","17 pounds");
            myArma2.getName();
            myArma2.getFood();
            myArma2.getBiome();
            myArma2.getWeight();
        }

    }
}
