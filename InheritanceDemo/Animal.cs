using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Animal
    {
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Animal constructor!");
        }

        public string Name { get; set; }
        protected int Age { get; set; }
        public double Weight { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }
    }
}
