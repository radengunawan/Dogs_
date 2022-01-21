using System;
using System.Collections.Generic;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog() { Breed = Breeds.Dachshund, Name = "Franz" },
                new Dog() { Breed = Breeds.Collie, Name = "Petunia" },
                new Dog() { Breed = Breeds.Pug, Name = "Porkchop" },
                new Dog() { Breed = Breeds.Dachshund, Name = "Brunhilda" },
                new Dog() { Name = "Zippy", Breed = Breeds.Collie},
                //new Dog() { Breed = Breeds.Corgi, Name = "Carrie" },
                new Dog ("Carrie", Breeds.Corgi)
               
            };
            dogs.Sort();
            foreach (Dog dog in dogs)
                Console.WriteLine(dog);
        }
    }

}
