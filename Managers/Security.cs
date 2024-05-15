using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionSystem.Classes;

namespace TransactionSystem.Managers
{
    internal class Security
    {
        public List<Stamp> StampHistory = new List<Stamp>();
        public int numberOfErrors;
        
        


        public void MakePreTransactionStamp(int clientID, double balance)
        {
            Stamp beforeStamp = new Stamp(clientID, balance);
            StampHistory.Add(beforeStamp);
        }
        public void MakePostTransactionStamp(int clientID, double balance)
        {
            Stamp afterStamp = new Stamp(clientID, balance);
            StampHistory.Add(afterStamp);
        }

        public void VerifyLastTransaction(int transactionAmount)
        {
            if(StampHistory.Count > 0)
            {
                if(transactionAmount == StampHistory[StampHistory.Count].balance - StampHistory[StampHistory.Count - 1].balance)
                {
                    return;
                }
                else
                {
                    numberOfErrors++;
                }
            }
        }

    }
}
