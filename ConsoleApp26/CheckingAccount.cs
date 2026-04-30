using System;
namespace ConsoleApp26
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;//-15,000 > -30,000
        public override void Withdraw(double amount)
        {
            if (overdraftLimit > amount)
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
            else
            {

                balance -= amount;
            }
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Overdraft Limit: {overdraftLimit}");
        }
    }
}
