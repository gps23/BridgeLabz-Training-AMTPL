using System;

namespace BridgeLabzConsoleApp.OOPS.ExampleForHierarchicalInheritance
{
    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(1001, 5000, 4.5);
            CheckingAccount checking = new CheckingAccount(1002, 3000, 1000);
            FixedDepositAccount fd = new FixedDepositAccount(1003, 20000, 12);

            Console.WriteLine("\n=== Savings Account ===");
            savings.DisplayAccountType();
            savings.DisplayDetails();
            savings.DisplaySavingsInfo();

            Console.WriteLine("\n=== Checking Account ===");
            checking.DisplayAccountType();
            checking.DisplayDetails();
            checking.DisplayCheckingInfo();

            Console.WriteLine("\n=== Fixed Deposit Account ===");
            fd.DisplayAccountType();
            fd.DisplayDetails();
            fd.DisplayFDInfo();

            Console.ReadLine();
        }
    }
}
