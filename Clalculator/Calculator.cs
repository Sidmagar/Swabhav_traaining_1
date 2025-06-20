
namespace MyCalculatorApp  
{
    public class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;

    public int Add(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Warning: Invalid input - array is null or empty.");
            return 0;
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }
}
}

