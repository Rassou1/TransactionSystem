using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionSystem.Managers;

namespace TransactionSystem.Classes
{
    internal class BankAccount
    {
        public double balance;
        Security security = new Security();

        public BankAccount() { }

        public void deposit(int amount, int clientID)
        {
            security.MakePreTransactionStamp(clientID, balance);
            balance += amount;
            security.MakePostTransactionStamp(clientID, balance);
            security.VerifyLastTransaction(amount);
        }



    }
}
