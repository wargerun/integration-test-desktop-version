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
    public partial class closedb : Form
    {
        public closedb()
        {
            InitializeComponent();
        }

        private void Отмена_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.value = null;
            MessageBox.Show("соединение с базой закрыто");
            Close();
        }
    }
}
