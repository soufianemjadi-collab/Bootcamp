// Account.cs
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MiniAtm
{
    public class Account
    {
        public string AccountNumber { get; }
        public int PIN { get; }
        public double Balance { get; private set; }
        public List<string> Transactions { get; }

        public Account(string accountNumber, int pin, double initialBalance)
        {
            AccountNumber = accountNumber;
            PIN = pin;
            Balance = initialBalance;
            Transactions = new List<string>();
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is {Balance.ToString("C", CultureInfo.CurrentCulture)}.");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            Balance += amount;
            Transactions.Add($"Deposit: {amount.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Deposit successful. New balance: {Balance.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
                return;
            }

            Balance -= amount;
            Transactions.Add($"Withdraw: {amount.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Withdrawal successful. New balance: {Balance.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public void ShowTransactions()
        {
            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transactions recorded yet.");
                return;
            }

            Console.WriteLine("Transaction History:");
            foreach (string transaction in Transactions)
            {
                Console.WriteLine($"- {transaction}");
            }
        }
    }
}