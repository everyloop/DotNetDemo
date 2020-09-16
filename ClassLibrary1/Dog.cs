using System;

namespace ClassLibrary1
{

    public class Dog
    {
        private string privat = "privat";
        public string pub = "public";
        internal string intstr = "internal";

        public void SayHey()
        {
            Console.WriteLine("Hey!");
        }
    }
}
