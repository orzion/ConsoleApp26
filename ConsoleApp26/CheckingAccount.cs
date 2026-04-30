using System;
namespace ConsoleApp26
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public CheckingAccount (int accountNumber, double balance,Customer customerOwner, double overdraftLimit): base(accountNumber, balance, customerOwner)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override void Withdraw(double amount)
        {
            if (balance -amount>= -overdraftLimit)
            {
                balance -= amount;
                
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Overdraft Limit: {overdraftLimit}");
        }
    }
}
