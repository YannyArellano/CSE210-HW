using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Welcome to the Number Guessing Game!");

        string response = "yes";
        Random randomGenerator = new Random();
        int totalGuesses = 0;

        while (response.ToLower() == "yes")
        {
            int number = randomGenerator.Next(1, 101);
            int guessNumber = -1;
            int guessCount = 0;

            while (guessNumber != number)
            {
                Console.Write("What is your guess number?: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guessNumber))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                guessCount++;
                totalGuesses++;

                if (number > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to continue? (yes/no): ");
            response = Console.ReadLine().Trim().ToLower();
        }

        Console.WriteLine($"Thanks for playing! :) You made {totalGuesses} total guesses.");
    }
}
