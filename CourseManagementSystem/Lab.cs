using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public class LabCourse : Course
    {
        public bool SafetyTrainingCompleted { get; set; }

        public LabCourse(string courseName, string instructor, bool safetyTrainingCompleted)
            : base(courseName, instructor)
        {
            if (!safetyTrainingCompleted)
                throw new ArgumentException("Safety training must be completed for lab courses.");

            SafetyTrainingCompleted = safetyTrainingCompleted;
        }

        public override void EnrollStudent()
        {
            Console.WriteLine($" Enrolled in Lab Course: {CourseName}");
        }
    }
}
