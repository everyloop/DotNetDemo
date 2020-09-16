using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Sparrow : Bird
    {
        public void ClimbThroughSmallHole()
        {
            Console.WriteLine($"{Name} climbs through a small hole!");
        }

        public override void Eat()
        {
            base.Eat();
            Sleep();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} goes to sleep!");
        }
    }
}
