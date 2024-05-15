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
        public Security security = new Security();
        int numberOfTransactions;
        Mutex depositMutex = new Mutex();

        public BankAccount() 
        {
            
        }

        public void deposit(int clientID, double amount, string info)
        {
            try
            {
                depositMutex.WaitOne();
                Stamp preTransactionStamp = security.MakePreTransactionStamp(clientID, balance, info);
                balance += amount;
                Stamp postTransactionStamp = security.MakePostTransactionStamp(clientID, balance, info);
                security.VerifyLastTransaction(amount, preTransactionStamp, postTransactionStamp);
                numberOfTransactions++;
            }
            finally
            {
                depositMutex.ReleaseMutex();
            }
        }

        public int transactionCount { get { return numberOfTransactions; } }


    }
}
