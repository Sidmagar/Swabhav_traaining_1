using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal class Professor: SalariedEmployee
    {
        public int ExperienceYears { get; set; }

        public Professor(int id, string address, DateTime dob, decimal baseSalary, int experienceYears)
            : base(id, address, dob, baseSalary)
        {
            ExperienceYears = experienceYears;
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.07m * ExperienceYears);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Experience: {ExperienceYears} years");
            Console.WriteLine($"Calculated Salary: {CalculateSalary()}");
        }

    }
}
