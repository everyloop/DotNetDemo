using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Bird : Animal
    {
        public Bird() : base("Untitled")
        {
            //Console.WriteLine("Bird constructor!");
        }

        public override void Die()
        {
            Console.WriteLine($"{Name} died!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying high!");
        }
    }
}
