using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public void Deposit(double amount) { 
           this.balance+= amount;
        }
        public void Deposit(double amount,int date)
        {
            this.balance += amount;
            Console.WriteLine($"Deposit of {amount} made on {date}");
        }
        public  virtual void Withdraw(double amount) {
            if(balance < amount)
            {
                Console.WriteLine("Insufficient funds");
            }
            else {
                this.balance -= amount;
            }
            
        }

        public virtual void PrintDetails() {
            Console.WriteLine($"Account Number: {accountNumber}, Balance: {balance}");
            customerOwner.PrintDetails();
        }

    }
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
    public class BankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts =new CheckingAccount[20];

        public void AddAccount(CheckingAccount account)
        {
           
        }
        private void PrintAccounts() { }
    }

    public class Customer {
        private string id;
        private string name;
        private string phoneNumber;
       
        public void PrintDetails()
        { 
             Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phoneNumber}");
        }
    }

}
