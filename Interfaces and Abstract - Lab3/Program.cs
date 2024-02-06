using System;

namespace lab3  
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to this Program!");

            // CREATE INSTANCE FROM DOG (ABSTRACT)
            Dog CreateDog () 
            { 
                
                Console.WriteLine("Write the Dog's name");
                string dogName = Console.ReadLine();
                Console.WriteLine($"Write {dogName}'s colour");
                string dogColour = Console.ReadLine();
                Console.WriteLine($"Write {dogName}'s age");
                int dogAge = int.Parse( Console.ReadLine() );

                Dog newDog = new Dog(dogName, dogColour, dogAge);
                return newDog;
            }


            // CREATE INSTANCE FROM CAT (ABSTRACT)
            Cat CreateCat ()
            {
                Console.WriteLine("Write the Cat's name");
                string catName = Console.ReadLine();
                Console.WriteLine($"Write {catName}'s colour");
                string catColour = Console.ReadLine();
                Console.WriteLine($"Write {catName}'s age");
                int catAge = int.Parse(Console.ReadLine());

                Cat newCat = new Cat(catName, catColour, catAge);
                return newCat;
            }

            // CREATE INSTANCE FROM DOG1 (INTERFACE)
            Dog1 CreateDog1()
            {

                Console.WriteLine("Write the Dog's name");
                string dogName = Console.ReadLine();
                Console.WriteLine($"Write {dogName}'s colour");
                string dogColour = Console.ReadLine();
                Console.WriteLine($"Write {dogName}'s height");
                double dogHeight = double.Parse(Console.ReadLine());
                Console.WriteLine($"Write {dogName}'s age");
                int dogAge = int.Parse(Console.ReadLine());

                Dog1 newDog = new Dog1(dogName, dogColour, dogHeight, dogAge);
                return newDog;
            }


            // CREATE INSTANCE FROM CAT (INTERFACE)
            Cat1 CreateCat1()
            {
                Console.WriteLine("Write the Cat's name");
                string catName = Console.ReadLine();
                Console.WriteLine($"Write {catName}'s colour");
                string catColour = Console.ReadLine();
                Console.WriteLine($"Write {catName}'s height");
                double catHeight = double.Parse(Console.ReadLine());
                Console.WriteLine($"Write {catName}'s age");
                int catAge = int.Parse(Console.ReadLine());

                Cat1 newCat = new Cat1(catName, catColour, catHeight, catAge);
                return newCat;
            }

            Console.WriteLine("INSTANCES OF ABSTRACT CLASSES:");
            Console.WriteLine(CreateDog());
            Console.WriteLine(CreateCat());
            Console.WriteLine("INSTANCES OF INTERFACES:");
            Console.WriteLine(CreateDog1());
            Console.WriteLine(CreateCat1());

            // Creating a list

            List<Animal> animals = new List<Animal>();

            // Creating instances

            Dog dog1 = new Dog("Buddy", "Brown", 3);
            Dog dog2 = new Dog("Max", "Black", 5);
            Dog dog3 = new Dog("Lucy", "White", 2);
            Dog dog4 = new Dog("Charlie", "Golden", 4);
            Dog dog5 = new Dog("Daisy", "Spotted", 1);
            Cat cat1 = new Cat("Whiskers", "Gray", 2);
            Cat cat2 = new Cat("Luna", "Black", 4);
            Cat cat3 = new Cat("Mittens", "Orange", 3);

            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(dog3);
            animals.Add(dog4);
            animals.Add(dog5);
            animals.Add(cat1);
            animals.Add(cat2);
            animals.Add(cat3);


            Console.WriteLine("Printing animal names on list:")
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

          

        }
    }
}