using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TransactionSystem.Classes;

namespace TransactionSystem.Managers
{
    internal class BankManager
    {
        BankAccount bankAccount = new BankAccount();
        List<Client> clients = new List<Client>();
        public Thread managerThread;
        public Thread clientThread
        bool isRunning = true;
        MainForm mainForm;

        public BankManager(MainForm mainForm) 
        {
            this.mainForm = mainForm;
        }


        public void InitializeThreads()
        {
            for (int i = 0; i <5; i++)
            {
                Client addNewClient = new Client();

            }
        }

    }
}
