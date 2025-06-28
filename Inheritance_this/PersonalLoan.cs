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

        // Constructor using 'this' and 'base'
        public PersonalLoan(string name, double amount, double interestRate, string purpose)
            : base(name, amount, interestRate)
        {
            this.Purpose = purpose;
        }

        public override void DisplayLoanDetails()
        {
            base.DisplayLoanDetails();
            Console.WriteLine($"Loan Type: Personal Loan, Purpose: {this.Purpose}");
        }
    }
}
