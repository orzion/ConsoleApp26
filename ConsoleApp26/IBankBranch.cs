using System;

namespace ConsoleApp26
{
    public interface IBankBranch
    {
        void AddAccount(CheckingAccount account);
        void PrintAccounts();
    }
}
