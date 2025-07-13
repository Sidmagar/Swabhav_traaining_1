namespace StudentCollege
{

    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Address: ");
            string studentAddress = Console.ReadLine();

            Console.Write("Enter Student DOB (yyyy-mm-dd): ");
            DateTime studentDob = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Student Branch: ");
            string branch = Console.ReadLine();

            Student student = new Student(studentId, studentAddress, studentDob, branch);

            Console.WriteLine("\n----- PROFESSOR REGISTRATION -----");

            Console.Write("Enter Professor ID: ");
            int professorId = int.Parse(Console.ReadLine());

            Console.Write("Enter Professor Address: ");
            string professorAddress = Console.ReadLine();

            Console.Write("Enter Professor DOB (yyyy-mm-dd): ");
            DateTime professorDob = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Professor Base Salary: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Years of Experience: ");
            int experience = int.Parse(Console.ReadLine());

            Professor professor = new Professor(professorId, professorAddress, professorDob, baseSalary, experience);

            Console.WriteLine("\n STUDENT DETAILS");
            student.DisplayInfo();

            Console.WriteLine("\n PROFESSOR DETAILS");
            professor.DisplayInfo();
        }
    }
}
