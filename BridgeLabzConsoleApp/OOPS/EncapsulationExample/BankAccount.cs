using System;

namespace BridgeLabzConsoleApp.OOPS.EncapsulationExample
{
    public class BankAccount
    {
        // Private fields - encapsulated data
        private string accountNumber;
        private double balance;

        // Constructor
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance; // using property
        }

        // Public getter for account number (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property for balance with validation
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Deposit amount must be positive !!!.");
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount.");
        }

        // Method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Current Balance: " + balance);
        }
    }
}
