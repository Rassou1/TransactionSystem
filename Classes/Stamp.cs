using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionSystem.Classes
{
    internal class Stamp
    {
        readonly int clientID;
        readonly double loggedBalance;
        string info;

        public Stamp(int clientID, double loggedBalance, string info)
        {
            this.loggedBalance = loggedBalance;
            this.clientID = clientID;
            this.info = info;
        }

        public int ClientID { get { return clientID; } }
        public double Balance { get { return loggedBalance; } }

        public override string ToString()
        {
            return $"Client ID: {clientID} {info}";
        }
    }
}
