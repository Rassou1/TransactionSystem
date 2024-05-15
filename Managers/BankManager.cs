using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionSystem.Classes;

namespace TransactionSystem.Managers
{
    internal class BankManager
    {
        BankAccount bankAccount = new BankAccount();
        List<Client> clients = new List<Client>();
        public Thread managerThread;
        public Thread clientThread;
        public BankManager() { }

    }
}
