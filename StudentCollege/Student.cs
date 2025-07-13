using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentCollege
{
    internal class Student: Employee
    {
        public string Branch { get; set; }

        public Student(int id, string address, DateTime dob, string branch)
            : base(id, address, dob)
        {
            Branch = branch;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Branch: {Branch}");
        }


    }
}
