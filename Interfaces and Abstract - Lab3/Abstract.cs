using System;

namespace lab3
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public Animal ()
        {
            // Constructor 
        }

        public virtual void Eat ()
        {
            // Override method 'Eat' 
        }

    }
}

