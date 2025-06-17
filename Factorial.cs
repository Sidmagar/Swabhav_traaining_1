namespace Factoirial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"\nFactorial of {num} is: {factorial}");
        }
    }
}
