namespace TransactionSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        private void UpdateProducts(string item, int i)
        {
            if (lstItems.InvokeRequired)
            {
                lstItems.Invoke(new Action<string, int>(UpdateProducts), item);
            }
            else
            {
                if (i == 0)
                    lstItems.Items.Clear();

                lstItems.Items.Add(item);
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
        }


        private void UpdateProductListBox(string item, int i)
        {
            if (lstItems.InvokeRequired)
            {
                lstItems.Invoke(new Action<string, int>(UpdateProductListBox), item, i);
            }
            else
            {
                if (i == 0)
                    lstItems.Items.Clear();

                lstItems.Items.Add(item);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.Exit();
        }

    }
}