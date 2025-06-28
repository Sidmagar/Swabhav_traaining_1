using Basic_inheritance;
using System;

namespace Inheritance_this
{
    internal class Program
    {
        // Define named constants instead of magic numbers
        private const string DefaultHomeLoanName = "Home Sweet Home";
        private const double DefaultHomeLoanAmount = 500_000;
        private const double DefaultHomeLoanInterestRate = 7.5;
        private const int DefaultHomeLoanYears = 20;

        private const string DefaultPersonalLoanName = "Car Loan";
        private const double DefaultPersonalLoanAmount = 20_000;
        private const double DefaultPersonalLoanInterestRate = 10.5;
        private const string DefaultPersonalLoanPurpose = "Buy a car";

        static void Main(string[] args)
        {
            HomeLoan homeLoan = new HomeLoan(
                DefaultHomeLoanName,
                DefaultHomeLoanAmount,
                DefaultHomeLoanInterestRate,
                DefaultHomeLoanYears);

            PersonalLoan personalLoan = new PersonalLoan(
                DefaultPersonalLoanName,
                DefaultPersonalLoanAmount,
                DefaultPersonalLoanInterestRate,
                DefaultPersonalLoanPurpose);

            homeLoan.DisplayLoanDetails();
            Console.WriteLine($"Total Amount to be Paid: {homeLoan.CalculateTotalAmount():F2}\n");

            personalLoan.DisplayLoanDetails();
            Console.WriteLine($"Total Amount to be Paid: {personalLoan.CalculateTotalAmount():F2}");
        }
    }
}