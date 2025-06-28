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

        // Base class constructor using 'this'
        public Loan(string name, double amount, double interestRate)
        {
            this.Name = name;
            this.Amount = amount;
            this.InterestRate = interestRate;
        }

        public virtual double CalculateTotalAmount()
        {
            return this.Amount + (this.Amount * this.InterestRate / 100);
        }

        public virtual void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan Name: {this.Name}, Amount: {this.Amount}, Interest Rate: {this.InterestRate}%");
        }
    }
}