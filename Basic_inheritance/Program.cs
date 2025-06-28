
namespace Basic_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeLoan homeLoan = new HomeLoan("Home Sweet Home", 500000, 7.5, 20);
            PersonalLoan personalLoan = new PersonalLoan("Car Loan", 20000, 10.5, "Buy a car");

            homeLoan.DisplayLoanDetails();
            Console.WriteLine($"Total Amount to be Paid: {homeLoan.CalculateTotalAmount():F2}\n");

            personalLoan.DisplayLoanDetails();
            Console.WriteLine($"Total Amount to be Paid: {personalLoan.CalculateTotalAmount():F2}");
        }
    }
}