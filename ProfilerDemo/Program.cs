using System;

namespace ProfilerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateImportantStuff();
        }

        static void CalculateImportantStuff()
        {
            for (int i = 0; i < 100; i++)
            {
                AwesomeMethod();
                DoingHeavyWork();
            }
        }

        static void AwesomeMethod()
        {
            for (int i = 0; i < 10000; i++)
            {

            }
        }

        static void DoingHeavyWork()
        {
            for (int i = 0; i < 100000; i++)
            {

            }
        }
    }
}
