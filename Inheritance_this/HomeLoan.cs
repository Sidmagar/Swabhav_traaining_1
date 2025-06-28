using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_inheritance
{
    internal class HomeLoan : Loan
    {
        public int Years { get; set; }

        // Constructor using 'this' and 'base'
        public HomeLoan(string name, double amount, double interestRate, int years)
            : base(name, amount, interestRate)
        {
            this.Years = years;
        }

        public override double CalculateTotalAmount()
        {
            return this.Amount * Math.Pow((1 + this.InterestRate / 100), this.Years);
        }

        public override void DisplayLoanDetails()
        {
            base.DisplayLoanDetails();
            Console.WriteLine($"Loan Type: Home Loan, Years: {this.Years}");
        }
    }
}