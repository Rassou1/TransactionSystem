using TransactionSystem.Managers;

namespace TransactionSystem
{
    public partial class Form1 : Form
    {
        BankManager bankManager;
        public Form1()
        {
            InitializeComponent();
            bankManager = new BankManager(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bankManager.InitializeThreads();
            bankManager.managerThread.Start();
        }
        public void UpdateResults(string item)
        {
            if (resultList.InvokeRequired)
            {
                resultList.Invoke(new Action<string>(UpdateResults), item);
            }
            else
            { 
                resultList.Items.Add(item);
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            bankManager.KillThreads();
            bankManager.isRunning = false;
        }

        public void UpdateQueue(string item)
        {
            if (queueList.InvokeRequired)
            {
                queueList.Invoke(new Action<string>(UpdateQueue), item);
            }
            else
            {
                queueList.Items.Add(item);
            }
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}