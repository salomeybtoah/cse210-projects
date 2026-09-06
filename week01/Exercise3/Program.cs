using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        // Outer loop for playing again
        while (playAgain == "yes")
        {
            // Generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("\nI'm thinking of a number between 1 and 100...");

            // Inner loop for guessing
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

            // Handle invalid input
            while (playAgain != "yes" && playAgain != "no")
            {
                Console.Write("Please enter 'yes' or 'no': ");
                playAgain = Console.ReadLine().ToLower();
            }
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}