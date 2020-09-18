using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Sparrow> dictionary = new Dictionary<string, Sparrow>();
            dictionary.Add("Alpha", new Sparrow() { Name = "Alpha", Weight = 1.0 } );
            dictionary.Add("Bravo", new Sparrow() { Name = "Bravo", Weight = 2.0 });
            dictionary.Add("Charlie", new Sparrow() { Name = "Charlie", Weight = 3.0 });

            string key;

            do
            {
                Console.Write("Enter name of sparrow: ");
                key = Console.ReadLine();
                
                if (dictionary.ContainsKey(key))
                {
                    Sparrow sparrow = dictionary[key];
                    Console.WriteLine($"{sparrow.Name} weights {sparrow.Weight} kg.");
                    sparrow.ClimbThroughSmallHole();
                }
                else if (key != "")
                {
                    Console.WriteLine("Can not find sparrow in dictionary!");
                }

            } while (key != "");

            Console.WriteLine();
            Console.WriteLine("Items in dictionary:");

            foreach(KeyValuePair<string, Sparrow> keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key} = {keyValuePair.Value.Weight}");
            }
        }
    }
}
