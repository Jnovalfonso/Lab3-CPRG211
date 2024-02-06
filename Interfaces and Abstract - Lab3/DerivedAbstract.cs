using System;
using System.Drawing;

namespace lab3
{   
    // DOG ABSTRACT CLASS
    public class Dog : Animal
    {
        // Default 'Dog' Costructor
        public Dog()
        {
            Name = "Buddy";
            Colour = "Brown";
            Age = 1;
        }

        // Defined 'Dog' Costructor
        public Dog(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs Eat Meat!");
        }
        public override string ToString()
        {
            return $"Dog Name: {Name}, Colour: {Colour}, Age: {Age}";
        }
    }

    // CAT ABSTRACT CLASS

    public class Cat : Animal
    {
        // Default 'Cat' Costructor
        public Cat()
        {
            Name = "Michi";
            Colour = "Orange";
            Age = 7;
        }

        // Defined 'Dog' Costructor
        public Cat(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice!");
        }

        public override string ToString()
        {
            return $"Cat Name: {Name}, Colour: {Colour}, Age: {Age}";
        }
    }

 
}
