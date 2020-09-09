using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; } = 0;

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Talk()
        {
            Console.WriteLine($"Meoow! My name is {Name}");
        }
    }
}
