using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Bird : Animal
    {
        public Bird() : base()
        {
            Console.WriteLine("Bird constructor!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying high!");
        }
    }
}
