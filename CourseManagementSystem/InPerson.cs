using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public class InPersonCourse : Course
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }

        public InPersonCourse(string courseName, string instructor, string roomNumber, int capacity)
            : base(courseName, instructor)
        {
            if (string.IsNullOrWhiteSpace(roomNumber))
                throw new ArgumentException("Room number is required.");
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");

            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public override void EnrollStudent()
        {
            Console.WriteLine($" Enrolled in In-Person Course: {CourseName} in Room {RoomNumber} (Capacity: {Capacity})");
        }
    }
}
