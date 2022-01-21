using System;
using System.Collections.Generic;
using System.Text;

namespace Dogs
{
    class Dog : IComparable<Dog>
    {
        public Breeds Breed { get; set; }
        public string Name { get; set; }

        public int CompareTo(Dog other)
        {
            if (this.Breed > other.Breed) return -1;
            if (this.Breed < other.Breed) return 1;
            return -Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"A {this.Breed} named {this.Name}";
        }

        public Dog()
        {
            
        }
        public Dog(string name, Breeds breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
    }
}
