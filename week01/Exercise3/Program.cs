using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int userGuess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number!");

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
