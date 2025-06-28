using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_inheritance
{
    internal class Loan
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double InterestRate { get; set; }

        // Base class constructor
        public Loan(string name, double amount, double interestRate)
        {
            Name = name;
            Amount = amount;
            InterestRate = interestRate;
        }

        // Virtual method to calculate total amount
        public virtual double CalculateTotalAmount()
        {
            return Amount + (Amount * InterestRate / 100);
        }

        // Virtual method to display loan details
        public virtual void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan Name: {Name}, Amount: {Amount}, Interest Rate: {InterestRate}%");
        }
    }
}