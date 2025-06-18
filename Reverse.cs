using System;
namespace Reverse{

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine("Reverse is: " + reversed);
    }
}
}