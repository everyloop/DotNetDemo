using AnimalLibrary;
using System;
using System.Collections.Generic;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow dataBreakpointDemo = new Sparrow() { Name = "BreakpointDemo", Weight = 100.0 };

            // TODO: Add more sparrows to dictionary
            Dictionary<string, Sparrow> dictionary = new Dictionary<string, Sparrow>();
            dictionary.Add("Alpha", new Sparrow() { Name = "Alpha", Weight = 1.0 });
            dictionary.Add("Bravo", new Sparrow() { Name = "Bravo", Weight = 2.0 });
            dictionary.Add("Charlie", new Sparrow() { Name = "Charlie", Weight = 3.0 });
            dictionary.Add("Delta", new Sparrow() { Name = "Delta", Weight = 4.0 });
            dictionary.Add("Echo", new Sparrow() { Name = "Echo", Weight = 5.0 });
            dictionary.Add("Foxtrot", new Sparrow() { Name = "Foxtrot", Weight = 6.0 });

            Console.WriteLine(dataBreakpointDemo.Name);

            dataBreakpointDemo.Name = "test";

            //PrintItemsInDictionary(dictionary);
            
            //            PrintNameAndWeight(dictionary["Echo"]);

            Console.WriteLine(dataBreakpointDemo.Name);

            // TODO: Count more numbers
            /*
            int x = 2;

            do
            {
                x = AddTwo(x);
            } while (x < 1000);
            */


        }

        static int AddTwo(int x)
        {
            return x + 2;
        }

        static void PrintNameAndWeight(Bird bird)
        {
            Console.WriteLine($"Name = {bird.Name}, Weight = {bird.Weight}");
        }

        static void PrintItemsInDictionary(Dictionary<string, Sparrow> dictionary)
        {
            Console.WriteLine("Items in dictionary:");
            foreach (KeyValuePair<string, Sparrow> keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key} = {keyValuePair.Value.Weight}");
                PrintNameAndWeight(keyValuePair.Value);
            }

        }
    }
}
