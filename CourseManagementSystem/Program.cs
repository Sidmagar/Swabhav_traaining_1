using CourseManagementSystem;
using System;
using UniversityCourseEnrollment;

namespace UniversityCourseEnrollment
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Select Course Type:\n1. Online\n2. In-Person\n3. Lab");
            string choice = Console.ReadLine();

            Console.Write(" Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write(" Enter Instructor Name: ");
            string instructor = Console.ReadLine();

            try
            {
                Course course = null;

                switch (choice)
                {
                    case "1":
                        Console.Write(" Enter Video Platform Link: ");
                        string link = Console.ReadLine();
                        course = new OnlineCourse(name, instructor, link);
                        break;

                    case "2":
                        Console.Write(" Enter Room Number: ");
                        string room = Console.ReadLine();
                        Console.Write(" Enter Capacity: ");
                        int capacity = int.Parse(Console.ReadLine());
                        course = new InPersonCourse(name, instructor, room, capacity);
                        break;

                    case "3":
                        Console.Write(" Has the student completed safety training? (yes/no): ");
                        string input = Console.ReadLine().ToLower();
                        bool safetyTrained = input == "yes";
                        course = new LabCourse(name, instructor, safetyTrained);
                        break;

                    default:
                        Console.WriteLine(" Invalid course type.");
                        return;
                }

                course.EnrollStudent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Enrollment Failed: {ex.Message}");
            }
        }
    }
}
