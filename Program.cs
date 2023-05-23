namespace GuessessNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Welcome to the Guess the Number game!");
            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.WriteLine("Can you guess the number?");

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number in {0} attempts.", attempts);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}