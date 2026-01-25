// ATM.cs
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MiniAtm
{
    public class ATM
    {
        private readonly Dictionary<string, Account> _accounts;

        public ATM(Dictionary<string, Account> accounts)
        {
            _accounts = accounts;
        }

        public Account Authenticate()
        {
            Console.Write("Enter account number: ");
            string? accountNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(accountNumber) || !_accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account not found.");
                return null;
            }

            Console.Write("Enter PIN: ");
            string? pinInput = Console.ReadLine();

            if (!int.TryParse(pinInput, out int pin))
            {
                Console.WriteLine("Invalid PIN format. Please enter numbers only.");
                return null;
            }

            Account account = _accounts[accountNumber];
            if (account.PIN != pin)
            {
                Console.WriteLine("Incorrect PIN.");
                return null;
            }

            Console.WriteLine("Authentication successful.");
            return account;
        }

        public string ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Transactions");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Switch Account (Bonus)");
            Console.Write("Select an option: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public string PerformAction(Account account, string choice)
        {
            switch (choice)
            {
                case "1":
                    account.CheckBalance();
                    break;
                case "2":
                    Console.Write("Enter deposit amount: ");
                    if (TryReadAmount(out double depositAmount))
                    {
                        account.Deposit(depositAmount);
                    }
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: ");
                    if (TryReadAmount(out double withdrawAmount))
                    {
                        account.Withdraw(withdrawAmount);
                    }
                    break;
                case "4":
                    account.ShowTransactions();
                    break;
                case "5":
                    return "exit";
                case "6":
                    return "switch";
                default:
                    Console.WriteLine("Invalid menu option. Please try again.");
                    break;
            }

            return "continue";
        }

        private static bool TryReadAmount(out double amount)
        {
            string? input = Console.ReadLine();
            if (!double.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out amount))
            {
                Console.WriteLine("Invalid amount. Please enter a numeric value.");
                return false;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return false;
            }

            return true;
        }
    }
}