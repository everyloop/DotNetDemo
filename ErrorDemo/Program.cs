using System;
namespace Guess20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 21);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Var god gissa på ett tal mellan 1-20.");
                if (!Int32.TryParse(Console.ReadLine(), out int guess)) continue;

                if (guess > randomNumber)
                {
                    Console.WriteLine("Din gissning var för hög!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Din gissning var för låg!");
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("Gissningen var korrekt! Grattis!");
                    isRunning = false;
                }
            }
        }
    }
}