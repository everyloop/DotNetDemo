using System;
using AnimalLibrary;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow(25, 1.80);
            {
                Console.WriteLine(sparrow.Volume);
            }
        }
    }
}
