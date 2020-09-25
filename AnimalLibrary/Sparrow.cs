using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AnimalLibrary
{
    [DebuggerDisplay("{Name, nq} väger {Weight}")]
    public class Sparrow : Bird
    {
        private double BMI;
        private double length;
        private float radius = 5.0f;

        public Sparrow(double BMI, double length)
        {
            this.BMI = BMI;
            this.length = length;
        }

        public float Volume => 4.0f/3.0f * MathF.PI * MathF.Pow(radius, 3.0f);

        protected override int Age //{ get => base.Age; set => base.Age = value; }
        {
            get 
            {
                return 15;
            }
            set
            {
                Console.WriteLine(value);
            }
        }
        public override double Weight => BMI * length * length;
        /*
        {
            get 
            {
                return BMI * length * length;
            }
        }
        */

        public void ClimbThroughSmallHole()
        {
            Console.WriteLine($"{Name} climbs through a small hole!");
        }

        public override void Eat()
        {
            base.Eat();
            Sleep();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} goes to sleep!");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
