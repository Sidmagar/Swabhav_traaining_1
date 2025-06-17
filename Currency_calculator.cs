namespace Currency_Calculator
{
    internal class Currency_calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter withdrawal amount :");
            string input = Console.ReadLine();
            int amount = 0;
            bool isNumeric = true;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c < '0' || c > '9')
                {
                    isNumeric = false;
                    break;
                }
                amount = amount * 10 + (c - '0'); 
            }

            if (!isNumeric)
            {
                Console.WriteLine("Invalid input. Please enter a numeric amount.");
                return;
            }

            // Check constraints
            if (amount > 50000)
            {
                Console.WriteLine("Amount exceeds withdrawal limit of 50000");
                return;
            }

            if (amount % 100 != 0)
            {
                Console.WriteLine("Amount should be in multiples of 100");
                return;
            }

            
            int notes2000 = amount / 2000;
            amount %= 2000;

            int notes500 = amount / 500;
            amount %= 500;

            int notes200 = amount / 200;
            amount %= 200;

            int notes100 = amount / 100;

            
            if (notes2000 > 0)
                Console.WriteLine("Two Thousand :" + notes2000);
            if (notes500 > 0)
                Console.WriteLine("Five Hundred :" + notes500);
            if (notes200 > 0)
                Console.WriteLine("Two Hundred :" + notes200);
            if (notes100 > 0)
                Console.WriteLine("Hundred :" + notes100);
        }
    }
}
