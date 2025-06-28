namespace Person_App_Constructor_Chaining;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a person with all properties taken as input
        Console.WriteLine("Enter Id:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Height :");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Weight :");
        int weight = int.Parse(Console.ReadLine());
        Person person1 = new Person(id, name, age, height, weight);
        person1.DisplayInfo();
        Console.WriteLine();
        // Create a person with default values for Height and Weight
        Console.WriteLine("Enter Id:");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        name= Console.ReadLine();
        Console.WriteLine("Enter Age:");
        age = int.Parse(Console.ReadLine());
        Person person2 = new Person(id, name, age);
        person2.DisplayInfo();
        // Create an enumeration instance

Console.WriteLine("Enter Enumeration Id:");
int enumId = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Enumeration Name:");
string enumName = Console.ReadLine();
Enumeration enumeration = new Enumeration(enumId, enumName, PersonType.Student);
enumeration.DisplayInfo();





    }
}

