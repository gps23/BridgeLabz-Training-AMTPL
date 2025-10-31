using System;

namespace BridgeLabzConsoleApp.ExampleForHierarchicalInheritance
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
        }
    }
}
