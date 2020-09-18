using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Sparrow> queue = new Queue<Sparrow>();

            Sparrow alpha = new Sparrow() { Name = "Alpha", Weight = 1.0 };
            Sparrow bravo = new Sparrow() { Name = "Bravo", Weight = 2.0 };
            Sparrow charlie = new Sparrow() { Name = "Charlie", Weight = 3.0 };

            Console.WriteLine($"{alpha} steps into the queue!");
            queue.Enqueue(alpha);

            Console.WriteLine($"{bravo} steps into the queue!");
            queue.Enqueue(bravo);

            Console.WriteLine($"{charlie} steps into the queue!");
            queue.Enqueue(charlie);

            Sparrow serveFirst = queue.Dequeue();

            serveFirst.Eat();

            Console.WriteLine();
            Console.WriteLine("The other sparrows in the queue dont get to eat! :(");
            
            foreach (Sparrow sparrow in queue)
            {
                sparrow.Fly();
            }
        }
    }
}
