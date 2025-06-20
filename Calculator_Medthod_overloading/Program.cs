using MyCalculatorApp;  

namespace MyCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Adding two integers: 5 + 10");
            Console.WriteLine("Result: " + calc.Add(5, 10));

            Console.WriteLine("\nAdding two doubles: 3.5 + 4.7");
            Console.WriteLine("Result: " + calc.Add(3.5, 4.7));

            Console.WriteLine("\nAdding array of integers: 1 + 2 + 3 + 4 + 5");
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Result: " + calc.Add(nums));

            Console.WriteLine("\nInvalid input: array is null.");
            Console.WriteLine("Result (should be 0): " + calc.Add(null));

            Console.WriteLine("\nInvalid input: array is empty.");
            int[] empty = new int[0];
            Console.WriteLine("Result (should be 0): " + calc.Add(empty));
        }
    }
}
