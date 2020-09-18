using System;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts here");
            Method1();
            Console.WriteLine("Program ends here");
        }

        static void Method1()
        {
            Console.WriteLine("Method 1 starts here");
            Method2(0);
            Console.WriteLine("Method 1 ends here");
        }

        static void Method2(int x)
        {
            x++;
            //Console.WriteLine($"x = {x}");
            if (x > 10000)
            {
                Console.WriteLine(x);
            }
            Method2(x);
        }
    }
}
