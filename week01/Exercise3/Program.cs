using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        int guessN = -1;

        Random randomGenerator = new Random();
        int magicN = randomGenerator.Next(1, 101);

        while ( magicN != guessN)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessN = int.Parse(guess);

            if (guessN < magicN)
            {
                Console.WriteLine("Higher");
            }
        
            else if (guessN > magicN)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
      
    }
}