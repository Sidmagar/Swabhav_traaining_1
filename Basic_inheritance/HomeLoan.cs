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

        // Derived class constructor calls base constructor
        public HomeLoan(string name, double amount, double interestRate, int years)
            : base(name, amount, interestRate)
        {
            Years = years;
        }

        // Override method to calculate total amount for home loan
        public override double CalculateTotalAmount()
        {
            return Amount * Math.Pow((1 + InterestRate / 100), Years);
        }

        // Override method to display loan details
        public override void DisplayLoanDetails()
        {
            base.DisplayLoanDetails();
            Console.WriteLine($"Loan Type: Home Loan, Years: {Years}");
        }
    }
}