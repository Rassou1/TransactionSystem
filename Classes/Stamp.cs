using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionSystem.Classes
{
    internal class Stamp
    {
        public int clientID;
        public double balance;

        public Stamp(int clientID, double balance)
        {
            this.clientID = clientID;
            this.balance = balance;
        }
    }
}
