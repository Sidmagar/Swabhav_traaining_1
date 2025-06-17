namespace Count_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Console.WriteLine("Total words: " + words.Length);
        }
    }
}
