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
        Mutex securityMutex = new Mutex();
        public string[] infoStrings;
        


        public Stamp MakePreTransactionStamp(int clientID, double balance, string info)
        {
            Stamp beforeStamp = new Stamp(clientID, balance, info);
            StampHistory.Add(beforeStamp);
            return beforeStamp;
        }
        public Stamp MakePostTransactionStamp(int clientID, double balance, string info)
        {
            Stamp afterStamp = new Stamp(clientID, balance, info);
            return afterStamp;
        }

        public void VerifyLastTransaction(double transactionAmount, Stamp preTransactionStamp, Stamp postTransactionStamp)
        {
            if (StampHistory.Count >= 0 && transactionAmount != postTransactionStamp.Balance - preTransactionStamp.Balance)
            {
                numberOfErrors++;
            }
        }

        public string[] SecurityInfoStrings()
        {
            try
            {
                securityMutex.WaitOne();
                if(StampHistory.Count == 0)
                {
                    return new string[] { "No transactions have been completed yet." };
                }

                infoStrings = new string[StampHistory.Count+1];

                infoStrings[0] = "Transaction Log";

                for (int i = 0; i < StampHistory.Count; i++)
                {
                    infoStrings[i+1] = StampHistory[i].ToString();
                }
                return infoStrings;
            }
            finally
            {
                securityMutex.ReleaseMutex();
            }
        }

    }
}
