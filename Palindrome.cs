namespace Palindrome
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPalindrome(num))
            {
                Console.WriteLine($"{num} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a palindrome number.");
            }
        }
        static bool IsPalindrome(int number)
        {
            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return original == reversed;
        }



    }
}
