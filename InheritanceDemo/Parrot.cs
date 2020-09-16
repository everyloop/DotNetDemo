using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Parrot : Bird
    {
        public Parrot(int Age)
        {
            Console.WriteLine("Parrot constructor!");
            this.Age = Age;
        }

        public void Talk(string text)
        {
            Console.WriteLine($"{Name} says: {text}");
        }
        
        public void Talk()
        {
            Console.WriteLine($"{Name} says: I am {Age} years old!");
        }
    }
}
