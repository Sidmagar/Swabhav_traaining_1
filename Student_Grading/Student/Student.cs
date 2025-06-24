using System;

namespace Student_Grading
{
    public class Student
    {
        public string StudentName { get; set; }
        public string RollNumber { get; set; }
        public int[] Marks { get; set; }

        public Student(string name, string rollNo, int[] marks)
        {
            StudentName = name;
            RollNumber = rollNo;

            if (marks.Length != 5)
            {
                Console.WriteLine("Enter the 5 subject marks corrctly");
            }
            Marks = marks;
        }

        public double CalculateAverage()
        {
            double total = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                total += Marks[i];
            }

            double average = total / Marks.Length;
            return Math.Round(average, 2);
        }

        public string CalculateGrade()
        {
            double avg = CalculateAverage();

            if (avg >= 90)
            {
                return "A+";
            }
            else if (avg >= 80)
            {
                return "A";
            }
            else if (avg >= 70)
            {
                return "B";
            }
            else if (avg >= 60)
            {
                return "C";
            }
            else if (avg >= 50)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }

        

        private void PrintRow(string label, string value)
        {
            Console.WriteLine(label.PadRight(13) + ": " + value);
        }

        public void PrintReport()
        {
            Console.WriteLine("\nStudent Report Card");
            

            PrintRow("Name", StudentName);
            PrintRow("Roll No", RollNumber);

            PrintRow("Marks", "[" + string.Join(", ", Marks) + "]");


            PrintRow("Average", CalculateAverage().ToString());
            PrintRow("Grade", CalculateGrade());
        }

        public static int[] GetMarks(int count)
        {
            int[] marks = new int[count];
            Console.WriteLine($"Enter marks for {count} subjects:");

            for (int i = 0; i < count; i++)
            {
                marks[i] = ReadValidatedMark(i + 1);
            }

            return marks;
        }

        private static int ReadValidatedMark(int subjectNumber)
        {
            while (true)
            {
                Console.Write($"Subject {subjectNumber}: ");
                if (int.TryParse(Console.ReadLine(), out int mark) && mark >= 0 && mark <= 100)
                    return mark;

                Console.WriteLine("Invalid input. Enter a number between 0 and 100.");
            }
        }
    }
}
