using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(12345, 105642.98, new Customer("C001", "Or Zion", "555-1234"));
            account1.PrintDetails();
            CheckingAccount checkingAccount = new CheckingAccount(account1.GetAccountNumber(),account1.GetBalance(),account1.GetCustomerOwner(), 10000);
            checkingAccount.PrintDetails();
            checkingAccount.Withdraw(110000);
            checkingAccount.PrintDetails();
            checkingAccount.Deposit(20000);
            checkingAccount.PrintDetails();
            BankBranch branch = new BankBranch(1, "123 Main St");
            branch.AddAccount(checkingAccount);

            BankAccount account2 = new BankAccount(12346, 165642.56, new Customer("C002", "James Smith", "058-4566-5657"));
            CheckingAccount checkingAccount2 = new CheckingAccount(account2.GetAccountNumber(), account2.GetBalance(), account2.GetCustomerOwner(), 30000);
            branch.AddAccount(checkingAccount2);

            branch.PrintAccounts();
        }
    }

   

}
