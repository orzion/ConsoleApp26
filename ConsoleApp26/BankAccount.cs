using System;


namespace ConsoleApp26
{
    public class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Deposit(double amount, int date)
        {
            this.balance += amount;
            Console.WriteLine($"Deposit of {amount} made on {date}");
        }
        public virtual void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                this.balance -= amount;
            }

        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}, Balance: {balance}");
            customerOwner.PrintDetails();
        }

    }
}
