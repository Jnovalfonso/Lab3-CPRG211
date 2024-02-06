using System;

namespace lab3
{
    // DOG INTERFACE
    public class Dog1 : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        // Default 'Dog1' Constructor
        public Dog1()
        {
            Name = "Buddy";
            Colour = "Brown";
            Height = 0.5;
            Age = 1;
        }

        // Defined 'Dog1' Costructor
        public Dog1(string name, string colour, double height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        // Implementing the Eat method 
        public void Eat()
        {
            Console.WriteLine($"Dogs eat meat!");
        }

        // Implementing the Cry method 
        public string Cry()
        {
            return $"Woof!";
        }

        public override string ToString()
        {
            return $"Dog Name: {Name}, Colour: {Colour}, Height:{Height} Age: {Age}";
        }
    }

    // CAT INTERFACE
    public class Cat1 : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        // Default 'Cat1' Constructor
        public Cat1()
        {
            Name = "Michi";
            Colour = "Orange";
            Height = 0.3;
            Age = 7;
        }

        // Defined 'Cat1' Costructor
        public Cat1(string name, string colour, double height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        // Implementing the Eat method 
        public void Eat()
        {
            Console.WriteLine($"Cats eat mice!");
        }

        // Implementing the Cry method 
        public string Cry()
        {
            return $"Meow!";
        }

        public override string ToString()
        {
            return $"Cat Name: {Name}, Colour: {Colour}, Height:{Height} Age: {Age}";
        }

    }
}
