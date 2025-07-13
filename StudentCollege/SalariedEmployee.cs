using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal class SalariedEmployee:Employee
    {
        public decimal BaseSalary { get; set; }

        public SalariedEmployee(int id, string address, DateTime dob, decimal baseSalary)
            : base(id, address, dob)
        {
            BaseSalary = baseSalary;
        }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary; 
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Base Salary: {BaseSalary}");
        }
    }
}
