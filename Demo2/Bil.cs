using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Bil : Train
    {
        public readonly int slumptal;

        public Bil() : base("Whatever")
        {
            Console.WriteLine("Bil konstruktor");
            Random rnd = new Random();
            slumptal = rnd.Next(101);
        }

        public static Bil CreateBil()
        {
            Bil b = new Bil();
            return b;
        }

        public override string ToString()
        {
            return "Denna bils slumpatal är " + slumptal;
        }
    }
}
