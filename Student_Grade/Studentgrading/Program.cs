
using StudentGradingApp;

namespace Studentgrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            StudentGrade student1 = new StudentGrade();
            StudentGrade student2 = new StudentGrade("Siddhant");
            StudentGrade student3 = new StudentGrade("Sunil", 56);
            StudentGrade student4 = new StudentGrade("Suresh", 75, 'X'); 

            student4.ShowStudentDetails();
        }
    }
}
