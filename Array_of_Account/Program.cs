using System;

namespace Array_of_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Accounts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (count < accounts.Length)
                        {
                            string accountNumber = Account.GenerateAccountNumber(accounts, count);
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Initial Balance: ");
                            double balance = Convert.ToDouble(Console.ReadLine());

                            if (balance < 500)
                            {
                                Console.WriteLine("Initial balance must be at least ₹500.");
                                break;
                            }

                            Console.WriteLine("Select Account Type:");
                            Console.WriteLine("1. Savings");
                            Console.WriteLine("2. Current");
                            Console.Write("Enter your choice 1 or ): ");
                            string Choice = Console.ReadLine();

                            string accountType;
                            if (Choice == "1")
                            {
                                accountType = "Savings";
                            }
                            else if (Choice == "2")
                            {
                                accountType = "Current";
                            }
                            else
                            {
                                Console.WriteLine("Invalid account type selected.");
                                break;
                            }

                            accounts[count] = new Account(accountNumber, name, balance, accountType);
                            Console.WriteLine(" Account Created Successfully.");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Account limit reached.");
                        }
                        break;

                    case "2": // Deposit
                        Console.Write("Enter Account Number: ");
                        string accNoDeposit = Console.ReadLine();
                        Account depositAccount = Array.Find(accounts, a => a != null && a.AccountNumber == accNoDeposit);
                        if (depositAccount != null)
                        {
                            Console.Write("Enter Amount to Deposit: ");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            depositAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "3": // Withdraw
                        Console.Write("Enter Account Number: ");
                        string accNoWithdraw = Console.ReadLine();
                        Account withdrawAccount = Array.Find(accounts, a => a != null && a.AccountNumber == accNoWithdraw);
                        if (withdrawAccount != null)
                        {
                            Console.Write("Enter Amount to Withdraw: ");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            withdrawAccount.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "4": // Display Accounts
                        Console.WriteLine("\nAll Accounts:");
                        foreach (var account in accounts)
                        {
                            if (account != null)
                            {
                                Console.WriteLine($"Account Number: {account.AccountNumber}, Name: {account.Name}, Balance: ₹{account.Balance}, Type: {account.AccountType}");
                            }
                        }
                        break;

                    case "5": // Exit
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 to 5.");
                        break;
                }
            }
        }
    }
}
