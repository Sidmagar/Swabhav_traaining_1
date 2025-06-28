using System;

namespace ProductApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        // default constructor to initialize the product details
        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }
        // parametrized constructor to initialize the product details
        public Product(int id, string name, double price)
        { this.Id = id;
            this.Name = name;
            this.Price = price;
            this.DiscountPercentage = 0;


        }

        // method to calculate the discounted prices
        public double GetDiscountedPrice()
        {
            return Price - (Price * DiscountPercentage / 100);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"D: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Original Price: ₹{Price}");
            Console.WriteLine($"Discount: {DiscountPercentage}%");
            Console.WriteLine($"Price After Discount: ₹{GetDiscountedPrice()}\n");
        }
    }
}
