using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public abstract class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        protected Course(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public abstract void EnrollStudent();
    }
}
