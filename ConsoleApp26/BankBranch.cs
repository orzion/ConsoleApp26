using System;

namespace ConsoleApp26
{
    public class BankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts = new CheckingAccount[20];

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
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
