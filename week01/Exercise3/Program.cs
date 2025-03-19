using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // This code was used for parts 1 and 2 when the user needed to specify a magic number.
        // Console.WriteLine("What is the magic number?");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;
        int attempts = 0;

        while (number != guess)
        {
            attempts++;
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            Console.WriteLine($"Attempt #{attempts} made.");

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"Total number of attempts: {attempts}");


    }
}