using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Xml.Linq;
namespace Integration
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединитьсяСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединитьсяСБДMySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьСоединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединитьсяСБДToolStripMenuItem,
            this.соединитьсяСБДMySQLToolStripMenuItem,
            this.закрытьСоединениеСБДToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // соединитьсяСБДToolStripMenuItem
            // 
            this.соединитьсяСБДToolStripMenuItem.Name = "соединитьсяСБДToolStripMenuItem";
            this.соединитьсяСБДToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.соединитьсяСБДToolStripMenuItem.Text = "Соединиться с БД MS SQL";
            this.соединитьсяСБДToolStripMenuItem.Click += new System.EventHandler(this.соединитьсяСБДToolStripMenuItem_Click);
            // 
            // соединитьсяСБДMySQLToolStripMenuItem
            // 
            this.соединитьсяСБДMySQLToolStripMenuItem.Name = "соединитьсяСБДMySQLToolStripMenuItem";
            this.соединитьсяСБДMySQLToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.соединитьсяСБДMySQLToolStripMenuItem.Text = "Соединиться с БД MySQL";
            this.соединитьсяСБДMySQLToolStripMenuItem.Click += new System.EventHandler(this.соединитьсяСБДMySQLToolStripMenuItem_Click);
            // 
            // закрытьСоединениеСБДToolStripMenuItem
            // 
            this.закрытьСоединениеСБДToolStripMenuItem.Name = "закрытьСоединениеСБДToolStripMenuItem";
            this.закрытьСоединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.закрытьСоединениеСБДToolStripMenuItem.Text = "Закрыть соединение с БД";
            this.закрытьСоединениеСБДToolStripMenuItem.Click += new System.EventHandler(this.закрытьСоединениеСБДToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(950, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Создать .xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(950, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Очистить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Список таблиц";
            // 
            // selection
            // 
            this.selection.Location = new System.Drawing.Point(949, 72);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(129, 23);
            this.selection.TabIndex = 11;
            this.selection.Text = "Выборка";
            this.selection.UseVisualStyleBackColor = true;
            this.selection.Click += new System.EventHandler(this.selection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Нет подключения к базе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество таблиц в базе:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(950, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Открыть .xml";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(630, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 277);
            this.listBox1.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(950, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Отправить .xml";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 413);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Integration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public void showtable(string query)
        {
            try
            {
                //string query = "SELECT * FROM users";
                using (DataTable dt = new DataTable())
                {
                    using (SqlConnection conn = new SqlConnection(Data.value))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                        {
                            da.Fill(dt);
                        }
                    }
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
               // MessageBox.Show("Нет соединения с базой данных");
            }
        }

        public void showtablemysql(string query)
        {
            try
            {
                //string query = "SELECT * FROM users";
                using (DataTable dt = new DataTable())
                {
                    using (MySqlConnection conn = new MySqlConnection(Datamysql.value2))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                        {
                            da.Fill(dt);
                        }
                    }
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
                // MessageBox.Show("Нет соединения с базой данных");
            }
        }

        public void makexml(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        conn.Open();
                        DataSet ds = new DataSet("users");
                        DataTable data = new DataTable("User");
                        ds.Tables.Add(data);
                        da.Fill(ds.Tables["User"]);
                        ds.WriteXml("userdb.xml", XmlWriteMode.WriteSchema);
                        MessageBox.Show("Файл userdb.xml успешно создан");
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных");
            }
        }

        public void cleartable()
        {
            int count = this.dataGridView1.Columns.Count;
            for(int i=0; i<count; i++)
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }
        }
        
        public void openxmlfile()
        {
            String xmlString = File.ReadAllText("userdb.xml");
            XDocument xdoc = XDocument.Load(new StringReader(xmlString));
            var xmlList = (from user in xdoc.Descendants("User")
                           select new
                           {
                               name = user.Descendants("name").SingleOrDefault(),
                               surname = user.Descendants("surname").SingleOrDefault(),
                               vrachfio = user.Descendants("vrachfio").SingleOrDefault(),
                               vphone = user.Descendants("vphone").SingleOrDefault()
                           }).ToList();
            var userlist = (from item in xmlList
                               select new
                               {
                                   name = item.name != null ? item.name.Value : null,
                                   surname = item.surname != null ? item.surname.Value : null,
                                   vrachfio = item.vrachfio != null ? item.vrachfio.Value : null,
                                   vphone = item.vphone != null ? item.vphone.Value : null
                               });
            
            foreach (var User in userlist)
            {
                listBox1.Items.Add(User.name);
                listBox1.Items.Add(User.surname);
                listBox1.Items.Add(User.vrachfio);
                listBox1.Items.Add(User.vphone);
                listBox1.Items.Add(" ");
            }
        }

        public void sendxmlfile()
        {
            String xmlString = File.ReadAllText("userdb.xml");
            XDocument xdoc = XDocument.Load(new StringReader(xmlString));
            var xmlList = (from user in xdoc.Descendants("User")
                           select new
                           {
                               name = user.Descendants("name").SingleOrDefault(),
                               surname = user.Descendants("surname").SingleOrDefault(),
                               vrachfio = user.Descendants("vrachfio").SingleOrDefault(),
                               vphone = user.Descendants("vphone").SingleOrDefault()
                           }).ToList();
            var userlist = (from item in xmlList
                            select new
                            {
                                name = item.name != null ? item.name.Value : null,
                                surname = item.surname != null ? item.surname.Value : null,
                                vrachfio = item.vrachfio != null ? item.vrachfio.Value : null,
                                vphone = item.vphone != null ? item.vphone.Value : null
                            });
            string name,surname,vrachfio,vphone;
            MySqlConnection conn = new MySqlConnection(Datamysql.value2);
            conn.Open();
            string encoding = "set names 'cp1251'";
            MySqlCommand u1 = new MySqlCommand(encoding, conn);
            u1.ExecuteNonQuery();
            string encoding2 = "set names 'utf8'";
            MySqlCommand u2 = new MySqlCommand(encoding2, conn);
            u2.ExecuteNonQuery();
            foreach (var User in userlist)
            {
                name = User.name;
                surname = User.surname;
                vrachfio = User.vrachfio;
                vphone = User.vphone;
                string query = "INSERT INTO testtable (name,surname,vrachfio,vphone) VALUES ('" + name + "','" + surname + "','" + vrachfio + "','" + vphone + "')";
               // string query1 = "INSERT INTO testtable (name,surname,vrachfio,vphone) VALUES ('namee','" + surname + "','" + vrachfio + "','" + vphone + "')";
                MySqlCommand c1 = new MySqlCommand(query, conn);
               // c1.Parameters.Add("namee", MySqlDbType.VarChar).Value = User.name;
                
                c1.ExecuteNonQuery();
                
            }
            MessageBox.Show("Данные были извлечены из xml и отправлены в БД mysql");
            conn.Close();
        }

        private login logwin;
        private closedb closecon;
        private mysqlconnect mysqlconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединитьсяСБДToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ToolStripMenuItem закрытьСоединениеСБДToolStripMenuItem;
        private Button button3;
        public ComboBox comboBox1;
        private Label label1;
        private Button selection;
        private selection select;
        public Label label2;
        private Label label3;
        private ToolStripMenuItem соединитьсяСБДMySQLToolStripMenuItem;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
    }
}

