using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot1 = new Parrot(34) { Weight = 20.0 };

            Console.WriteLine();
            
            parrot1.Eat();
            parrot1.Fly();
            parrot1.Talk("Hello there!");
            parrot1.Talk();

            Console.WriteLine();

            Sparrow sparrow1 = new Sparrow() { Name = "Tom", Weight = 1.5 };
            sparrow1.Eat();
            sparrow1.Fly();
            sparrow1.ClimbThroughSmallHole();
        }
    }
}
