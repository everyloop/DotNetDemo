using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    abstract class Animal
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
        protected int Age { get; set; }
        public double Weight { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }

        public abstract void Die();
    }
}
