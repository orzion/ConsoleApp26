using System;

namespace ConsoleApp26
{
    public class BankBranch: IBankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts = new CheckingAccount[20];

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
        }

        public int GetBranchNumber()
        {
            return this.branchNumber;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public CheckingAccount[] GetAccounts()
        {
            return this.accounts;
        }
        public void SetBranchNumber(int branchNumber)
        {
            this.branchNumber = branchNumber;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public void SetAccounts(CheckingAccount[] accounts)
        {
            this.accounts = accounts;
        }
        public void AddAccount(CheckingAccount account)
        {
            for (int i = 0; i < accounts.Length; i++) {
                if (accounts[i] == account) {
                    Console.WriteLine("Account already exists");
                  break;
                }
                if(accounts[i] == null) {
                   accounts[i] =  account;
                    Console.WriteLine("Account added successfully");
                   break;
                }
            }
        }
        public void PrintAccounts() {
            for (int i = 0; i < accounts.Length; i++) {
                if (accounts[i] != null) {
                    accounts[i].PrintDetails();
                }
            }
        }
    }
}
