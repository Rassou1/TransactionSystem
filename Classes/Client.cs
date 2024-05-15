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
        public BankAccount account;
        int amount;
        int totalAmountTransactioned;

        public bool Running
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        public Client(int id, int amount)
        {
            while(isRunning)
            {
                this.amount = amount;
                amount = rnd.Next(-10, 10);
                account.deposit(id, amount);
                totalAmountTransactioned += amount;
            }
        }
    }
}
