using System;
using System.Collections.Generic;

public class Account
{
    // Properties
    public string AccountNumber { get; private set; }
    public int PIN { get; private set; }
    public double Balance { get; private set; }

    // Optional transaction history
    private List<string> Transactions = new List<string>();

    // Constructor
    public Account(string accountNumber, int pin, double balance)
    {
        AccountNumber = accountNumber;
        PIN = pin;
        Balance = balance;
    }

    // Prints the current balance
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ${Balance}");
    }

    // Adds money to balance and stores transaction
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        Balance += amount;
        Transactions.Add($"Deposit: ${amount}");
        Console.WriteLine($"Deposit successful! New balance: ${Balance}");
    }

    // Subtracts money if sufficient balance and stores transaction
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Transactions.Add($"Withdraw: ${amount}");
        Console.WriteLine($"Withdrawal successful! New balance: ${Balance}");
    }

    // Prints all transaction records (optional)
    public void ShowTransactions()
    {
        Console.WriteLine("\nTransaction History:");

        if (Transactions.Count == 0)
        {
            Console.WriteLine("No transactions found.");
        }
        else
        {
            foreach (string transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
