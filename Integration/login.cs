using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//для работы с sql
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = Owner as Form1;
            try
            {
                var server = textBox1.Text;
                var database = textBox2.Text;
                var connectionString = String.Format("Server={0}; Database={1}; Integrated Security=SSPI;", server, database);
                var cnn = new SqlConnection(connectionString);
                cnn.Open();
                Data.value = connectionString;
                MessageBox.Show("Подключено");
                var tables = cnn.GetSchema("Tables");
                int k = 0;
                foreach (DataRow row in tables.Rows)
                {
                    f.comboBox1.Items.Add(row["TABLE_NAME"]);
                    k++;
                }
                f.label2.Text = k.ToString();
                Close();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
                Close();
            }
        }
    }
}
