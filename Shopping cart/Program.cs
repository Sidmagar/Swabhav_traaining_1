namespace Shopping_cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Pen", 10, 10);        
            Product p2 = new Product(2, "Notebook", 50, 5);     
            Product p3 = new Product(3, "Pencil", 5, 0);        
            Product p4 = new Product(4, "Eraser", 8, 20);       

            LineItem item1 = new LineItem(101, 2, p1);
            LineItem item2 = new LineItem(102, 3, p2);
            LineItem item3 = new LineItem(103, 5, p3);
            LineItem item4 = new LineItem(104, 1, p4);

            List<LineItem> cart = new List<LineItem> { item1, item2, item3, item4 };

            Console.WriteLine("Shopping Cart:");
            Console.WriteLine("ID   Name       Qty   UnitPrice   Total");

            double totalCost = 0;

            foreach (var item in cart)
            {
                int id = item.Id;
                string name = item.Product.Name;
                int qty = item.Quantity;
                double unitPrice = item.Product.CalculateDiscountedPrice();
                double total = item.CalculateLineItemCost();

                Console.WriteLine($"{id,-4} {name,-10} {qty,-5} {unitPrice,-11:F2} {total,-8:F2}");
                totalCost += total;
            }

            
            Console.WriteLine($"Total Cart Cost: {totalCost}");

        }
    }
}
