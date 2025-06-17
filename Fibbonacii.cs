namespace Fibbonaci_8elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int first = 0, second = 1;
            Console.WriteLine("Fibbonaci series upto" +n+ "Elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write(first + "");
                int next = first + second;
                first = second;
                second = next;

            }

        }
    }
}
