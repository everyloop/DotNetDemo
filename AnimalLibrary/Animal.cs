using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public abstract class Animal
    {
        public Animal(string name) : this(name, 25.0)
        {
        }

        public Animal(string name, double weight) : base()
        {
            Name = name;
            Weight = weight;
            //Console.WriteLine("Animal constructor!");
        }

        public string Name { get; set; }
        protected virtual int Age { get; set; }
        public virtual double Weight { get; }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }

        public abstract void Die();
    }
}
