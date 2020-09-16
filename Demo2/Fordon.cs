using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Fordon
    {
        public Fordon()
        {
            Console.WriteLine("Fordon konstruktor");
        }

        public float Length { get; set; }

        public void Tuta()
        {
            Console.WriteLine("Tuuuuut!");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
