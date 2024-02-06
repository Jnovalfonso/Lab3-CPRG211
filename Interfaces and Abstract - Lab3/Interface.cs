using System;

namespace lab3
{

    public interface IAnimal 
    {
        public string Name {get; set;}
        public string Colour { get; set;}
        public double Height { get; set;}
        public int Age { get; set;}

        public void Eat();
        public string Cry();
    }
}