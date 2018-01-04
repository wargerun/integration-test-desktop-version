using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object selectedItem1 = comboBox1.SelectedItem;
            string query1 = "select name from syscolumns where id = object_id('" + selectedItem1.ToString() + "')";
            Object selectedItem2 = comboBox2.SelectedItem;
            string query2 = "select name from syscolumns where id = object_id('" + selectedItem2.ToString() + "')";
            //string query3 = "select count(*) from syscolumns where id = object_id('" + selectedItem1.ToString() + "')";
            //string query4 = "select count(*) from syscolumns where id = object_id('" + selectedItem2.ToString() + "')";
            SqlConnection conn = new SqlConnection(Data.value);
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(query1, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            comboBox4.DataSource = ds1.Tables[0];
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Name";
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conn);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            comboBox5.DataSource = ds2.Tables[0];
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "Name";
            SqlDataAdapter da3 = new SqlDataAdapter(query2, conn);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            comboBox6.DataSource = ds3.Tables[0];
            comboBox6.DisplayMember = "Name";
            comboBox6.ValueMember = "Name";
            SqlDataAdapter da4 = new SqlDataAdapter(query2, conn);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            comboBox7.DataSource = ds4.Tables[0];
            comboBox7.DisplayMember = "Name";
            comboBox7.ValueMember = "Name";
            SqlDataAdapter da5 = new SqlDataAdapter(query1, conn);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            comboBox3.DataSource = ds5.Tables[0];
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Name";
            SqlDataAdapter da6 = new SqlDataAdapter(query2, conn);
            DataSet ds6 = new DataSet();
            da6.Fill(ds6);
            comboBox8.DataSource = ds6.Tables[0];
            comboBox8.DisplayMember = "Name";
            comboBox8.ValueMember = "Name";
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Data.value);
            conn.Open();
            var tables = conn.GetSchema("Tables");
            foreach (DataRow row in tables.Rows)
            {
                comboBox1.Items.Add(row["TABLE_NAME"]);
                comboBox2.Items.Add(row["TABLE_NAME"]);
            }
            MessageBox.Show("список таблиц получен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Data.value);
            conn.Open();
            Form1 f = Owner as Form1;
            Object t1 = comboBox1.SelectedItem;
            Object t2 = comboBox2.SelectedItem;
            var s1 = comboBox4.Text;
            var s2 = comboBox5.Text;
            var s3 = comboBox6.Text;
            var s4 = comboBox7.Text;
            var k1 = comboBox3.Text;
            var k2 = comboBox8.Text;
            //string testquery = " select [name],[surname],[ФИО врача],[телефон] from [users],[doctor] where [id]=[Номер врача] ";
            string query = " select ["+s1.ToString() + "],["+s2.ToString() + "],["+s3.ToString() + "],["+s4.ToString() + "] from  ["+t1.ToString() + "] , ["+t2.ToString() + "]  where ["+k1.ToString() + "] = ["+k2.ToString() + "]";
            f.showtable(query);
            f.makexml(query);
            conn.Close();
        }
    }
}
