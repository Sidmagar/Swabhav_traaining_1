namespace Dayofweekenum
{
    internal class Dayofweekenum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                Day selectedDay = (Day)dayNumber;
                Console.WriteLine($"\nDay is: {selectedDay}");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number between 1 and 7.");
            }
        }
    }

    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
