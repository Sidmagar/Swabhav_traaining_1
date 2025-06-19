

namespace Number_guessing
{
    class number_guess
    {
        static void Main(string[] args)
        {
            string playAgain = "yes";

            while (playAgain == "yes")
            {
                Random rng = new Random();
                int number = rng.Next(1, 101); 
                int guess = 0;
                int attempts = 0;
                int maxAttempts = 5;

                Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");

                while (guess != number && attempts < maxAttempts)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;

                    if (guess < number)
                    {
                        Console.WriteLine("Sorry, too low.");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Sorry, too high.");
                    }
                    else
                    {
                        Console.WriteLine("You won! You guessed it in " + attempts + " attempts");
                    }
                }

                if (guess != number)
                {
                    Console.WriteLine("You lost. The correct number was " + number);
                }

                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine();
            }

            
        }
    }
}
