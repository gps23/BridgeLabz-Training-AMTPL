using System;

namespace BridgeLabzConsoleApp.ExampleForHierarchicalInheritance
{
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("This is a Savings Account.");
        }

        public void DisplaySavingsInfo()
        {
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}
