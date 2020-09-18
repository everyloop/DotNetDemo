using System;
using AnimalLibrary;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow charlie = new Sparrow() { Name = "Charlie" };

            //new Sparrow().Fly();

            sparrows.Add(new Sparrow() { Name = "Alpha" });
            sparrows.Add(new Sparrow() { Name = "Bravo" });
            sparrows.Add(new Sparrow() { Name = "Delta" });
            sparrows.Add(new Sparrow() { Name = "Echo" });

            Console.WriteLine("Loop 1");

            foreach (Sparrow sparrow in sparrows)
            {
                Console.WriteLine(sparrow.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Loop 2");

            sparrows.Insert(2, charlie);

            foreach (Sparrow sparrow in sparrows)
            {
                Console.WriteLine(sparrow.Name);
            }

            Console.WriteLine();
            Console.WriteLine($"Index of charlie = {sparrows.IndexOf(charlie)}");

            Console.WriteLine();
            Console.WriteLine($"sparrows contains {sparrows.Count} elements.");

            Console.WriteLine();
            Console.WriteLine($"sparrows contains charlie = {(sparrows.Contains(charlie))}");

            Sparrow[] sparrowArray = sparrows.ToArray();
        }
    }
}
