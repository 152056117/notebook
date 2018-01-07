using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace note
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = connection.GetConnString();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into users(id,name,password) values('" + null + "','" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Form4 frm = new Form4();
                frm.Show();
                this.Close();
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
