
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }

        private double percentage;

        // Default Constructor
        public Student() { }

        //Parameterised Constructor
        public Student(int rollNo, string name, double cgpa)
        {
            RollNo = rollNo;
            CGPA = cgpa;
            Name = name;
            Console.WriteLine("Object created successfully");
        }

        public double CalculatePercentage()
        {
            return percentage = Math.Round(7.1 * CGPA + 11, 2);
        }

        public override string ToString()
        {
            return $"Roll No: {RollNo}, Name: {Name}, CGPA: {CGPA}";
        }
    }
}
