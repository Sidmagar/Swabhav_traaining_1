using System;

class PrimeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        // Count how many numbers divide the given number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // A prime number has exactly 2 divisors: 1 and itself
        if (count == 2)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
