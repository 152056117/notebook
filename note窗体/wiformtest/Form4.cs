using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiformtest
{
    public partial class Formwelcom : Form
    {
        public Formwelcom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formwelcom_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click()
        {
        
        }

        private void label1_Click_1()
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count=0;
            if(textBox1.Text=="高新季"&&textBox2.Text=="111111")
            {
                var frm = new Form2();
                this.Hide();
               
                frm.Show();
               

            }
            else
            {
                MessageBox.Show("请输入有效登录信息","注意！");
                count++;
            }
            while(count==3)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
