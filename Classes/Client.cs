using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TransactionSystem.Classes
{
    internal class Client
    {
        Random rnd = new Random();
        bool isRunning = true;
        public BankAccount bankAccount;
        double amount;
        double totalAmountTransactioned;
        int id;
        public bool Running
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        public double totalAmount
        {
            get { return totalAmountTransactioned; }
            set { totalAmountTransactioned = value; }
        }

        public Client(int id, BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
            this.id = id;
        }

        public void Run()
        {
            while (isRunning)
            {
                amount = rnd.Next(-10, 10);
                string clientTransactionInfo = amount <= 0 ? $"Withdrew {amount}" : $"Deposited {amount}";
                bankAccount.deposit(id, amount, clientTransactionInfo);
                totalAmountTransactioned += amount;
                
                Thread.Sleep(rnd.Next(1000, 10000));
            }
        }
    }
}
