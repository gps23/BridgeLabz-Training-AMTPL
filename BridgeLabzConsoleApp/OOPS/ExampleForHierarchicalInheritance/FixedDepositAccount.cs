using System;

namespace BridgeLabzConsoleApp.OOPS.ExampleForHierarchicalInheritance
{
    class FixedDepositAccount : BankAccount
    {
        public int DepositDuration { get; set; } // in months

        public FixedDepositAccount(int accountNumber, double balance, int duration)
            : base(accountNumber, balance)
        {
            DepositDuration = duration;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("This is a Fixed Deposit Account.");
        }

        public void DisplayFDInfo()
        {
            Console.WriteLine($"Deposit Duration: {DepositDuration} months");
        }
    }
}
