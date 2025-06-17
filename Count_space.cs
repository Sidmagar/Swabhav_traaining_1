namespace Count_spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence here");
            string sentence = Console.ReadLine();
            int spaceCount = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine("Space count" + spaceCount);

        }
    }
}
