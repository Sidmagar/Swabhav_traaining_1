using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Account
{
    internal class Account
    {
        
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public static Random random = new Random();
        // Default constructor
        public Account(string accountNumber, string name, double balance, string accountType)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            AccountType = accountType;
        }
        // method to geneerate a account number
        public static string GenerateAccountNumber(Account[] accounts,int count)
        {
            string accNo;
            bool isUnique = false;
            do
            {
                accNo = "ACC" + random.Next(1000, 9999).ToString();
                isUnique = true;
                for (int i = 0; i <count; i++)
                {
                    if (accounts[i] != null && accounts[i].AccountNumber == accNo)
                    {
                        isUnique = false;
                        break;
                    }
                }
            }while (!isUnique);
            return accNo;

        }
        // deposit method
         public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        // withdraw method to maintain 500 minimum balance
        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Minimum balance of 500 must be maintained.");
            }
        }
        // method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine("-------------------------------");
        }




    }
}
