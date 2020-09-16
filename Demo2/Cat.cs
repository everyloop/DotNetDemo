using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    public class Cat
    {
        public readonly string catname = "";
        private int catage;

        private Cat(string name, int age)
        {
            catname = name;
            catage = age;
        }

        public void SayName()
        {
            Console.WriteLine(catname);
        }

        public static void SaySomething()
        {
            Console.WriteLine("Something");
        }

        public static Cat CreateCat()
        {
            return new Cat("privatkatt", 5);
        }
    }
}
