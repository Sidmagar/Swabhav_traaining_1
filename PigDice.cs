namespace PigDice
{
    internal class PigDice
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalScore = 0;
            int turnCount = 0;

            while (totalScore < 20)
            {
                turnCount++;
                int turnScore = 0;
                Console.WriteLine($"\nTURN {turnCount}");

                while (true)
                {
                    Console.Write("Roll or hold? (r/h): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "r")
                    {
                        int die = random.Next(1, 7); // 1 to 6
                        Console.WriteLine($"Die: {die}");

                        if (die == 1)
                        {
                            Console.WriteLine("Turn over. No score.");
                            turnScore = 0;
                            
                        }
                        else
                        {
                            turnScore += die;
                        }
                    }
                    else if (choice == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"Score for turn: {turnScore}");
                        Console.WriteLine($"Total score: {totalScore}");
                        
                    }
                    else
                    {
                        Console.WriteLine(" Please enter 'r' to roll or 'h' to hold.");
                    }
                }
            }

            Console.WriteLine($"\nYou finished in {turnCount} turns!");
            Console.WriteLine("Game over!");
        }
    }
}
