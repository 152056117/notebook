using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace note
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        //实例化一个可输入区域，接收Form1中RichTextBox的值
        public RichTextBox rtb = new RichTextBox();
        //定义查找的开始位置
        public int startIndex = 0;
        public int flag = -1;
        //设置查找，替换按钮是否启用
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            startIndex = rtb.SelectionLength;
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                flag = rtb.Text.IndexOf(textBox1.Text, startIndex, StringComparison.CurrentCulture);
            }
            else
            {
                flag = rtb.Text.IndexOf(textBox1.Text, startIndex, StringComparison.CurrentCultureIgnoreCase);
            }
            if (flag > -1)
            {
                rtb.SelectionBackColor = rtb.BackColor;
                startIndex = flag + 1;
                rtb.SelectionStart = flag;
                flag = -1;
                rtb.SelectionLength = textBox1.Text.Length;
                rtb.SelectionBackColor = Color.SkyBlue;
            }
            else
            {
                MessageBox.Show("找不到\"" + textBox1.Text + "\"", "提示");
            }
        }
        //替换按钮的方法
        private void button2_Click(object sender, EventArgs e)
        {
            if (rtb.SelectedText == "")
            {
                button1_Click(sender, e);
            }
            else
            {
                rtb.SelectionBackColor = rtb.BackColor;
                rtb.SelectedText = textBox2.Text;
                button1_Click(sender, e);
            }
        }
        //销毁当前窗体
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //全部替换按钮事件
        private void button3_Click(object sender, EventArgs e)
        {
            startIndex = 0;
            while(startIndex <=rtb.Text.Length)
            {
                //清除选中的字体的背景色
                rtb.SelectionBackColor = rtb.BackColor;
                rtb.SelectedText = textBox2.Text;
                button1_Click(sender, e);
                if (startIndex == rtb.Text.Length-1)
                {
                    startIndex = rtb.Text.Length+1;          
                }
            }
        }
    }
}
