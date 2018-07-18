using System;
using System.Windows.Forms;

namespace Integration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void соединитьсяСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logwin = new login();
            logwin.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM users";
            Object selectedItem = comboBox1.SelectedItem;
            string query = "SELECT * FROM " + selectedItem.ToString() + "";
            showtable(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";
            makexml(query);
        }

        public void oolStripMenuItem_Click(object sender, EventArgs e)
        {
            closecon = new closedb();
            closecon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartable();
        }

        private void selection_Click(object sender, EventArgs e)
        {
            select = new selection();
            select.Show(this);
        }

        private void соединитьсяСБДMySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mysqlconnect = new mysqlconnect();
            mysqlconnect.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openxmlfile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sendxmlfile();
        }
    }
}
