using System;
using System.Drawing;
using System.Windows.Forms;

namespace note
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //实例化一个可输入区域，接收Form1中RichTextBox的值
        public RichTextBox rtb = new RichTextBox();
        //定义查找的开始位置
        public int startIndex = 0;
        public int flag = -1;
        //“查找下一个”按钮
        public void button1_Click(object sender, EventArgs e)
        {
            if (startIndex == 0)
            {
                //获取光标的位置
                startIndex = rtb.SelectionStart;
            }
            if (this.checkBox1.Checked)
            {
                //向下查找
                if (this.radioButton2.Checked)
                {
                    //索引:CurrentCulture 使用区域敏感排序规则和当前区域比较字符串。
                    //CurrentCultureIgnoreCase 使用区域敏感排序规则、当前区域来比较字符串，
                    //同时忽略被比较字符串的大小写。 
                    flag = rtb.Text.IndexOf(textBox1.Text, startIndex, StringComparison.CurrentCulture);
                }
                //向上查找
                if (this.radioButton1.Checked && startIndex>2)
                {
                    flag = rtb.Text.LastIndexOf(textBox1.Text, startIndex-2, StringComparison.CurrentCulture);
                } 
            }
            else
            {
                if (this.radioButton2.Checked)
                {
                    flag = rtb.Text.IndexOf(textBox1.Text, startIndex, StringComparison.CurrentCultureIgnoreCase);
                }
                if (this.radioButton1.Checked && startIndex > 2)
                {
                    flag = rtb.Text.LastIndexOf(textBox1.Text, startIndex-2, StringComparison.CurrentCultureIgnoreCase);
                }
            }
            if (flag > -1)
            {
                //设置选中字体的背景颜色
                rtb.SelectionBackColor = rtb.BackColor;
                startIndex = flag+1;
                rtb.SelectionStart = flag;             
                flag = -1;
                //获取选中字体的长度
                rtb.SelectionLength = textBox1.Text.Length;
                rtb.SelectionBackColor = Color.SkyBlue;
            }
            else
            {
                MessageBox.Show("找不到\"" + textBox1.Text + "\"","提示");
            }
            
        }
        //销毁当前窗体
        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //设置查找按钮是否启用
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;//启用
            }
            else
            {
                button1.Enabled = false;//禁用
            }
        }
    }
}
