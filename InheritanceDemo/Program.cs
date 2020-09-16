using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot1 = new Parrot(34);

            parrot1.Eat();
            parrot1.Fly();
            parrot1.Talk("Hello there!");
            parrot1.Talk();

            Console.WriteLine();

            Sparrow sparrow1 = new Sparrow() { Name = "Tom", Weight = 1.5 };
            sparrow1.Eat();
            sparrow1.Fly();
            sparrow1.ClimbThroughSmallHole();

            Parrot parrot2 = new Parrot(15) { Name = "Pelle", Weight = 45.6 }; ;
            Parrot parrot3 = new Parrot(15) { Name = "Anna", Weight = 235.6 }; ;
            Sparrow sparrow2 = new Sparrow() { Name = "Mats", Weight = 23.4 }; ;

            Bird[] birds = { parrot1, parrot2, sparrow1, parrot3, sparrow2 };

            Console.WriteLine();
            Console.WriteLine("Bird array:");
            Console.WriteLine();

            foreach (Bird bird in birds)
            {
                bird.Eat();
                if (bird is Parrot)
                {
                    Parrot temporaryParrot = (Parrot)bird;

                    //(bird as Parrot).Talk();
                    temporaryParrot.Talk();
                    temporaryParrot.Fly();
                }
                else
                {
                    Console.WriteLine($"{bird.Name} can not talk!");
                }
            }

            Console.WriteLine();

            foreach(Bird bird in birds)
            {
                bird.Die();
            }
        }
    }
}
