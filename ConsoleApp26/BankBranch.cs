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
                  break;
                }
                if(accounts[i] == null) {
                   accounts[i] =  account;
                   break;
                }
            }
        }
        private void PrintAccounts() {
            for (int i = 0; i < accounts.Length; i++) {
               accounts[i].PrintDetails();
            }
        }
    }
}
