using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 5;
            Console.WriteLine(a);

            const int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
            }

            if (x == 5)
            {
                Console.WriteLine("Value of x is 5");
            }
            else if (x == 10)
            {
                Console.WriteLine("Value of x is 10");
            }
            else if (x == 15)
            {
                Console.WriteLine("Value of x is 15");
            }
            else
            {
                Console.WriteLine("Unknown value");
            }

        }

        static void CountToTen()
        {
            int i = 0;

            Console.WriteLine("Startar loop.");

            while (i < 10)
            {
                i++;
                if (i == 5) continue;

                Console.WriteLine(i);
            }

            Console.WriteLine("Slutar loop.");
        }
    }
}
