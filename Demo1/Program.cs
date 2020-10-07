using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Factorial(4));
        }

        static int Factorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

    }
}
