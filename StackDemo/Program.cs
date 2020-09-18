using System;
using System.Collections.Generic;
using AnimalLibrary;
using System.Linq;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Sparrow> stack = new Stack<Sparrow>();

            Sparrow alpha = new Sparrow() { Name = "Alpha", Weight = 1.0 };
            Sparrow bravo = new Sparrow() { Name = "Bravo", Weight = 2.0 };
            Sparrow charlie = new Sparrow() { Name = "Charlie", Weight = 3.0 };

            Console.WriteLine($"Push {alpha} on top of the stack!");
            stack.Push(alpha);

            Console.WriteLine($"Push {bravo} on top of the stack!");
            stack.Push(bravo);

            Console.WriteLine($"Pop {bravo} from top of the stack!");
            Sparrow topSparrow = stack.Pop();
            Console.WriteLine($"{topSparrow} was removed from top of the stack!");

            Console.WriteLine($"Push {charlie} on top of the stack!");
            stack.Push(charlie);

            Console.WriteLine();
            Console.WriteLine($"There is {stack.Count} sparrows on the stack:");
            
            foreach(Sparrow sparrow in stack)
            {
                sparrow.Fly();
            }
        }
    }
}
