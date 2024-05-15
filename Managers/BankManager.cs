using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TransactionSystem.Classes;

namespace TransactionSystem.Managers
{
    internal class BankManager
    {
        BankAccount bankAccount = new BankAccount();
        List<Client> clients = new List<Client>();
        public Thread managerThread;
        public Thread clientThread;
        public bool isRunning = true;
        Form1 mainForm;

        public BankManager(Form1 mainForm) 
        {
            this.mainForm = mainForm;
        }

        public void Run()
        {
            while (isRunning)
            {
                UpdateResultListBox();
                UpdateQueueListBox();
                Thread.Sleep(1000);
            }
        }

        public void UpdateResultListBox()
        {
            string[] infoStrings = returnFinalTransactionInfo();
            
            if (mainForm.resultList.InvokeRequired)
            {
                mainForm.resultList.Invoke(new Action(UpdateResultListBox));
            }
            else
            {
                mainForm.resultList.Items.Clear();
                foreach (string str in infoStrings)
                {
                    mainForm.UpdateResults(str);
                }
            }
        }

        public void UpdateQueueListBox()
        {
            string[] securityStrings = returnSecurityInfoStrings();

            if (mainForm.queueList.InvokeRequired)
            {
                mainForm.queueList.Invoke(new Action(UpdateQueueListBox));
            }
            else
            {
                mainForm.queueList.Items.Clear();
                foreach (string str in securityStrings)
                {
                    mainForm.UpdateQueue(str);
                }
            }
        }

        public void InitializeThreads()
        {
            for (int i = 0; i <5; i++)
            {
                Client newClient = new Client(i, bankAccount);
                clients.Add(newClient);
            }
            foreach (Client c in clients) 
            {
                Thread clientThread = new Thread(c.Run);
                clientThread.Start();
            }
            managerThread = new Thread(this.Run);
        }

        public void KillThreads()
        {
            foreach(Client c in clients)
            {
                c.Running = false;
            }
        }

        public double ClientTotal()
        {
            double totalClientTransactions = 0;
            foreach (Client client in clients)
            {
                totalClientTransactions += client.totalAmount;
            }
            return totalClientTransactions;
        }

        public string[] returnFinalTransactionInfo()
        {
            double clientTotal = ClientTotal();
            string[] finalTransactionInfo = new string[4];
            finalTransactionInfo[0] = $"The number of total transactions is: {bankAccount.transactionCount}";
            finalTransactionInfo[1] = $"The total amount transacted by all clients is: {clientTotal}";
            finalTransactionInfo[2] = $"The current balance of the account is: {bankAccount.balance}";
            finalTransactionInfo[3] = $"The number of errors in stamps is: {bankAccount.security.numberOfErrors}";

            return finalTransactionInfo;
        }

        public string[] returnSecurityInfoStrings()
        {
            string[] securityInfoStrings = bankAccount.security.SecurityInfoStrings();
            return securityInfoStrings;
        }
    }
}
