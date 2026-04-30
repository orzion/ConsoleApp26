using System;


namespace ConsoleApp26
{
    public class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public BankAccount(int accountNumber, double balance, Customer customerOwner)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.customerOwner = customerOwner;
        }

        public int GetAccountNumber()
        {
            return this.accountNumber;
        }
        public double GetBalance()
        {
            return this.balance;
        }
        public Customer GetCustomerOwner()
        {
            return this.customerOwner;
        }
        
        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public void SetCustomerOwner(Customer customerOwner)
        {
            this.customerOwner = customerOwner;
        }

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
