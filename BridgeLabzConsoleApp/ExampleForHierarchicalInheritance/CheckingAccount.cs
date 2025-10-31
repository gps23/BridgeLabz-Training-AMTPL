using System;

namespace BridgeLabzConsoleApp.ExampleForHierarchicalInheritance
{
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("This is a Checking Account.");
        }

        public void DisplayCheckingInfo()
        {
            Console.WriteLine($"Withdrawal Limit: {WithdrawalLimit:C}");
        }
    }
}
