using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_inheritance
{
    internal class PersonalLoan : Loan
    {
        public string Purpose { get; set; }

        // Derived class constructor calls base constructor
        public PersonalLoan(string name, double amount, double interestRate, string purpose)
            : base(name, amount, interestRate)
        {
            Purpose = purpose;
        }

        // Override method to display loan details
        public override void DisplayLoanDetails()
        {
            base.DisplayLoanDetails();
            Console.WriteLine($"Loan Type: Personal Loan, Purpose: {Purpose}");
        }
    }
}