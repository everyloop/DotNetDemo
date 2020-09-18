using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Parrot : Bird, IStuffThatRuns, IEnumerable, IEnumerator
    {
        private int count = 0;

        public Parrot(int Age)
        {
            //Console.WriteLine("Parrot constructor!");
            this.Age = Age;
        }

        public object Current => count.ToString();

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            return count++ < 5;
        }

        public void Reset()
        {
            count = 0;
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is running!");
        }

        public void Talk(string text)
        {
            Console.WriteLine($"{Name} says: {text}");
        }
        
        public void Talk()
        {
            Console.WriteLine($"{Name} says: I am {Age} years old!");
        }
    }
}
