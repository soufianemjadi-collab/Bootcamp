// Program.cs
using System;
using System.Collections.Generic;

namespace MiniAtm
{
    public static class Program
    {
        public static void Main()
        {
            Dictionary<string, Account> accounts = new Dictionary<string, Account>
            {
                { "1001", new Account("1001", 1234, 1500.00) },
                { "2002", new Account("2002", 4321, 820.50) },
                { "3003", new Account("3003", 2468, 250.75) }
            };

            ATM atm = new ATM(accounts);
            Console.WriteLine("Welcome to the ATM Machine!");

            Account? currentAccount = AuthenticateWithRetries(atm);
            if (currentAccount == null)
            {
                Console.WriteLine("Too many failed attempts. Exiting.");
                return;
            }

            bool exitRequested = false;
            while (!exitRequested)
            {
                string choice = atm.ShowMenu();
                string actionResult = atm.PerformAction(currentAccount, choice);

                switch (actionResult)
                {
                    case "exit":
                        exitRequested = true;
                        break;
                    case "switch":
                        Console.WriteLine("Switching accounts...");
                        Account? switchedAccount = AuthenticateWithRetries(atm);
                        if (switchedAccount != null)
                        {
                            currentAccount = switchedAccount;
                        }
                        else
                        {
                            Console.WriteLine("Failed to switch accounts. Staying with current account.");
                        }
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the ATM Machine! Here’s a summary of your transactions:");
            currentAccount.ShowTransactions();
            currentAccount.CheckBalance();
        }

        private static Account? AuthenticateWithRetries(ATM atm)
        {
            const int maxAttempts = 3;
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Account? account = atm.Authenticate();
                if (account != null)
                {
                    return account;
                }

                if (attempt < maxAttempts)
                {
                    Console.WriteLine($"Authentication failed. Attempts remaining: {maxAttempts - attempt}.");
                }
            }

            return null;
        }
    }
}