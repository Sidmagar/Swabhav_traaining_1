using System;

namespace DeveloperInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check if arguments are passed
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass the input string as a command-line argument.");
                return;
            }
           
            // Read the first argument
            string input = args[0]; // Expected: "Sachin,Aurionrpo,Mumbai"

            // Split the input by comma
            string[] parts = input.Split(',');

            // Validate that we have exactly 3 parts
            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid input format. Please pass data as: Name,Company,Location");
                return;
            }

            // Assign values
            string name = parts[0];
            string company = parts[1];
            string location = parts[2];

            // Display output
            Console.WriteLine("Developer name is : " + name);
            Console.WriteLine("Company name is : " + company);
            Console.WriteLine("Location is : " + location);
        }
    }
}
