using System.Threading.Channels;

namespace Student_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student array to store objects
            Student[] students = new Student[3];
            int count = 0;
            int rollNo;
            string name;
            double cgpa = 0.0;

            //taking input from user to create objects with validation
            while (count < students.Length)
            {
                Console.WriteLine($"\nEnter details for Student {count + 1}");
                Console.Write("Enter Roll no: ");
                rollNo = int.Parse(Console.ReadLine());
                if (rollNo < 0)
                {
                    Console.WriteLine("Roll no should be positive, object creation failed.");
                    continue;
                }
                Console.Write("Enter CGPA: ");
                cgpa = double.Parse(Console.ReadLine());
                if (cgpa < 1 || cgpa > 10)
                {
                    Console.WriteLine("CGPA should be in the range 1-10, object creation failed.");
                    continue;
                }
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                if (name.Length < 5) name = "";
                students[count] = new Student(rollNo, name, cgpa);
                count++;
            }

            Console.WriteLine("\nDisplaying data for all students:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\n{students[i].ToString()}");
                Console.WriteLine($"Percentage for {students[i].Name} is: {students[i].CalculatePercentage()}");
            }
        }
    }
}