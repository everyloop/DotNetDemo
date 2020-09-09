using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = { new Cat("Findus", 4), new Cat("Pelle", 7), new Cat("Sverker", 2) };

            foreach (Cat cat in cats)
            {
                cat.Talk();
            }
        }
    }
}
