using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public class OnlineCourse : Course
    {
        public string VideoPlatformLink { get; set; }

        public OnlineCourse(string courseName, string instructor, string videoPlatformLink)
            : base(courseName, instructor)
        {
            if (string.IsNullOrWhiteSpace(videoPlatformLink))
                throw new ArgumentException("Video platform link is required for online courses.");

            VideoPlatformLink = videoPlatformLink;
        }

        public override void EnrollStudent()
        {
            Console.WriteLine($" Enrolled in Online Course: {CourseName} on {VideoPlatformLink}");
        }
    }
}
