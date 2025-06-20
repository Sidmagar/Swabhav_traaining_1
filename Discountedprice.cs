using System;

class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsBestseller { get; set; }

    // Constructor
    public Book(string title, string author, double price, bool isBestseller)
    {
        Title = title;
        Author = author;
        Price = price;
        IsBestseller = isBestseller;
    }

    // Method to calculate discounted price
    public double CalculateDiscountedPrice()
    {
        double discountedPrice = Price;

        if (IsBestseller)
        {
            discountedPrice -= discountedPrice * 0.10; // 10% discount
        }

        if (Price > 500)
        {
            discountedPrice -= discountedPrice * 0.05; // Additional 5% discount
        }

        return discountedPrice;
    }

    // Display book info
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Original Price: {Price}");
        Console.WriteLine($"Is Bestseller: {IsBestseller}");
        Console.WriteLine($"Discounted Price: {CalculateDiscountedPrice()}");
    }
}

// Sample usage
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("The Power of Habit", "Charles Duhigg", 600.0, true);
        book1.DisplayInfo();

        Console.WriteLine();

        Book book2 = new Book("C# in Depth", "Jon Skeet", 450.0, false);
        book2.DisplayInfo();
    }
}
