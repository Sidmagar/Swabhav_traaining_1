
namespace StudentGradingApp
{
    public class StudentGrade
    {
        private string studentName;
        private int studentScore;
        private char studentGrade;

        public string StudentName
        {
            get { return studentName; } set { studentName = value; }
        }

        public int StudentScore
        {
            get { return studentScore; } set { studentScore = value; }
        }

        public char StudentGradeValue
        {
            get { return studentGrade; } set { studentGrade = value; }
        }

        // Default constructor
        public StudentGrade() { }

        // Constructor with name
        public StudentGrade(string studentName)
        {
            this.studentName = studentName;
        }

        // Constructor with name and score
        public StudentGrade(string studentName, int studentScore)
        {
            this.studentName = studentName;
            this.studentScore = studentScore;
        }

        // Constructor with name, score, and grade
        public StudentGrade(string studentName, int studentScore, char studentGrade)
        {
            this.studentName = studentName;
            this.studentScore = studentScore;
            this.studentGrade = DetermineGrade(studentScore); // override passed grade
        }

        // Grade assignment logic
        private static char DetermineGrade(int score)
        {
            if (score >= 90) return 'A';
            else if (score >= 80) return 'B';
            else if (score >= 70) return 'C';
            return 'D';
        }

        // Display method
        public void ShowStudentDetails()
        {
            Console.WriteLine("Displaying student information:");
            Console.WriteLine($"Name: {studentName}\nScore: {studentScore}\nGrade: {studentGrade}\n");
        }
    }
}
