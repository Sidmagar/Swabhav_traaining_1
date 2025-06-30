using System;

namespace PigDice_Object_Calesthenics
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            new Game().Start();
        }
    }
    public class Dice
    {
        private readonly Random random = new Random();

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }

    public class Turn
    {
        private int turnScore = 0;
        private readonly Dice dice = new Dice();

        public int Play()
        {
            while (true)
            {
                Console.Write("Roll or hold? (r/h): ");
                string input = Console.ReadLine();

                if (input == "r")
                {
                    int rolledValue = dice.Roll();
                    Console.WriteLine($"Die: {rolledValue}");

                    if (rolledValue == 1)
                    {
                        Console.WriteLine("Turn over. No score.");
                        return 0;
                    }

                    turnScore += rolledValue;
                }

                if (input == "h")
                {
                    Console.WriteLine($"Score for turn: {turnScore}");
                    return turnScore;
                }

                if (input != "r" && input != "h")
                {
                    Console.WriteLine("Invalid input. Please enter 'r' or 'h'.");
                }
            }
        }
    }

    public class Game
    {
        private int totalScore = 0;
        private int turnNumber = 1;

        public void Start()
        {
            PrintGameRules();

            while (!IsGameOver())
            {
                Console.WriteLine($"\nTURN {turnNumber}");
                int scoreThisTurn = new Turn().Play();

                totalScore += scoreThisTurn;
                Console.WriteLine($"Total score: {totalScore}");

                turnNumber++;
            }

            EndGame();
        }

        private void PrintGameRules()
        {
            Console.WriteLine("------------ PIG DICE GAME -------------");
            Console.WriteLine("\n** Rules of the Game **");
            Console.WriteLine("-> See how many turns it takes you to get to 20.");
            Console.WriteLine("-> Turn ends when you hold or roll a 1.");
            Console.WriteLine("-> If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("-> If you hold, you save all points for the turn.");
        }

        private bool IsGameOver()
        {
            return totalScore >= 20;
        }

        private void EndGame()
        {
            Console.WriteLine($"\nYou finished in {turnNumber - 1} turns!");
            Console.WriteLine("Game over!");
        }
    }
}