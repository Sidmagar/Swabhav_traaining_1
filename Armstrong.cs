namespace ARMSTRONG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsArmstrong(num))
                Console.WriteLine("Armstrong Number!!");
            else
                Console.WriteLine("Not an Armstrong Number!!");

        }
        public static bool IsArmstrong(int number)
        {
            int original = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number /= 10;
            }

            return sum == original;
        }
    }
}



        
    
