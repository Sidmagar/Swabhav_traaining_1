

class Book
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsBestseller { get; set; }

    
    public Book(string title, string author, double price, bool isBestseller)
    {
        Title = title;
        Author = author;
        Price = price;
        IsBestseller = isBestseller;
    }

    
    public double CalculateDiscountedPrice()
    {
        double discountedPrice = Price;
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Original Price: ${Price:0.00}");

        if (IsBestseller)
        {
            Console.WriteLine($"'{Title}' is a bestseller. Applying 10% discount.");
            discountedPrice -= discountedPrice * 0.10;
        }

        if (Price > 500)
        {
            Console.WriteLine($"'{Title}' is priced over 500. Applying additional 5% discount.");
            discountedPrice -= discountedPrice * 0.05;
        }

        Console.WriteLine($"Final Discounted Price: ${discountedPrice:0.00}");
        Console.WriteLine(); // Blank line for better readability
        return discountedPrice;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Create book instances
        Book book1 = new Book("The Power of Habit", "Charles Duhigg", 600.00, true);
        Book book2 = new Book("C# Programming", "Jane Doe", 450.00, false);
        Book book3 = new Book("Beginner's Guide to AI", "Sam Tech", 520.00, false);
        Book book4 = new Book("Fast Money", "Rachel Green", 300.00, true);

        // Calculate and print discounted prices
        book1.CalculateDiscountedPrice();
        book2.CalculateDiscountedPrice();
        book3.CalculateDiscountedPrice();
        book4.CalculateDiscountedPrice();
    }
}
