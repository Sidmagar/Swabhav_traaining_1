

namespace Student_Grading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter roll number: ");
            string rollNo = Console.ReadLine();

            int[] marks = Student.GetMarks(5);

            Student student = new Student(name, rollNo, marks);
            student.PrintReport();
        }
    }
}
