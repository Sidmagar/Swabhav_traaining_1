using System;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Wireless Mouse", 800, 10);
            Product product2 = new Product(102, "Bluetooth Speaker", 1500);

            Console.WriteLine("Product Details:\n");
            product1.DisplayDetails();
            product2.DisplayDetails();

            Console.ReadLine();
        }
    }
}
