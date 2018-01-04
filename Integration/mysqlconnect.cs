using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class mysqlconnect : Form
    {
        public mysqlconnect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var server = textBox1.Text;
            var username = textBox2.Text;
            var password = textBox3.Text;
            var bdname = textBox4.Text;
            var encoding = "utf8";
            var port = 3306;
            try
            {
                string connection = String.Format( "server=" + server + ";user=" + username + ";charset=" + encoding +  ";database=" + bdname + ";port=" + port + ";password=" + password + ";");
                var conn = new MySqlConnection(connection);
                conn.Open();
                Datamysql.value2 = connection;
                MessageBox.Show("Соединение установлено");
                string query = "select * from users";
                Form1 f = Owner as Form1;
                f.showtablemysql(query);
                conn.Close();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
            }

        }
    }
}
