using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace note
{
    public partial class Form1 : Form
    {
        public static string path = @"C:\Users\93985\Desktop\笔记本\课堂笔记\c#";
        public static  string name=null;
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();//实例化查找窗体
        Form3 form3 = new Form3();//实例化替换窗体
        public string filepath = "";//文件路径
        //新建记事本
        //public void new_Click(object sender, EventArgs e)
        //{
        //    if (richTextBox1.Modified)//判断输入区是否被修改
        //    {
        //        save_Click(sender, e);
        //        richTextBox1.Text = "";//清空输入框
        //    }else  
        //        richTextBox1.Text = "";
        //}
        //打开文件
        public void open_Click(object sender, EventArgs e)
        {
            ////“打开”对话框，主要用于打开文件
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            ////设置打开文件格式
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{   
            //    //对文件进行读写操作
            //    StreamReader sTmp = new StreamReader(openFileDialog1.FileName, Encoding.Default);
            //    richTextBox1.Text = "";
            //    this.Text=openFileDialog1.SafeFileName+" - 记事本";
            //    //读取文件内容
            //    richTextBox1.Text = sTmp.ReadToEnd();
            //}
            openFileDialog1.InitialDirectory = "D:\\";            // 这里是初始的路径名
            //openFileDialog1.Filter = "类文件|*.cs|所有文件|*.*";  //设置打开文件的类型
            openFileDialog1.RestoreDirectory = true;              //设置是否还原当前目录
            openFileDialog1.FilterIndex = 0;                      //设置打开文件类型的索引
            string path = "";                                     //用于保存打开文件的路径
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
        //保存文件
        public void save_Click(object sender, EventArgs e)
        {
            //另存为对话框，用于将文本保存到指定的位置
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //定义要打开的文件格式
            //saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            //显示一个"提示框"
            //if (MessageBox.Show("需要保存文件吗？", "提示框", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        if (filepath.Length == 0)
            //        {
                        
            //            //获取要打开文件的绝对路径
            //            //filepath = saveFileDialog1.FileName;
            //            filepath = path;
            //        }
               filepath = path;
                    StreamWriter sTmp = new StreamWriter(filepath);
                    sTmp.Write(richTextBox1.Text);//输出流
                    sTmp.Flush();//清除缓存
                    sTmp.Close();
               // }
            //}
        }
        //另存为
        public void saveWhere_Click(object sender, EventArgs e)
        {
            save_Click(sender, e);
        }
        //打印
        public void print_Click(object sender, EventArgs e)
        {
            //打印对话框，用于选择打印机，打印页数及确定其他与打印机相关的设置
            PrintDialog pd = new PrintDialog();
            //显示一个模态打印对话框
            pd.ShowDialog();
        }
        //退出
        public void exit_Click(object sender, EventArgs e)
        {
            save_Click(sender, e);
            this.Close();
        }
        //字体
        public void font_Click(object sender, EventArgs e)
        {
            //字体对话框，用于设置字体
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        //打印设置
        public void set_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }
        //撤消
        public void return_Click(object sender, EventArgs e)
        {
            //撤消最新的撤消命令。换句话说，撤消位于撤消堆栈上的最新撤消单元
            richTextBox1.Undo();
        }
        public void 剪切XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //从文本编辑控件中删除当前选定内容，并将其复制到 Clipboard
            richTextBox1.Cut();
        }
        public void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择文本编辑控件的全部内容。 
            richTextBox1.SelectAll();
        }
        public void 复制VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将文本控件的当前选定内容复制到Clipboard。 
            richTextBox1.Copy();
        }
        public void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将剪贴板的内容粘贴到文本编辑控件中的当前选定内容上。
            richTextBox1.Paste();
        }
        public void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清除属性的本地值。
            richTextBox1.Clear();
        }
        public void 关于记事本AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
        public void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.rtb = richTextBox1;
            form2.ShowDialog(this);
        }
        public void 替换RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.rtb = richTextBox1;
            form3.ShowDialog(this);
        }
        public void 时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取系统当前时间
            DateTime time = DateTime.Now;
            //格式化日期
            string dat = string.Format("{0:yyyy-MM-dd HH:mm:ss dddd}",time);
            richTextBox1.AppendText(dat);
        }
        private void 查找下一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.button1_Click(sender,e);
        }
        //对“自动换行”进行选定和取消
        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行WToolStripMenuItem.Checked)
            {
                richTextBox1.WordWrap = false;
                自动换行WToolStripMenuItem.Checked = false;
            }
            else
            {
                自动换行WToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }
        //对“状态栏”进行选定和取消
        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (状态栏ToolStripMenuItem.Checked)
            {
                statusStrip1.Visible = false;
                状态栏ToolStripMenuItem.Checked = false;
            }
            else
            {
                状态栏ToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }
        //对“工具栏”进行选定和取消
       
        private void 帮助主题HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不会使用请百度Microsoft记事本");
        }
        //设置状态栏的显示时间
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
        //设置状态栏的行值和列值
        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "行 " + Control.MousePosition.X + "   列 " + Control.MousePosition.Y;
        }
        //设置“编辑”中的按钮是否启用
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {                
                剪切XToolStripMenuItem.Enabled = true;
                复制VToolStripMenuItem.Enabled = true;
                删除DToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                剪切XToolStripMenuItem.Enabled = false;
                复制VToolStripMenuItem.Enabled = false;
                删除DToolStripMenuItem.Enabled = false;
                
            } 
            if (richTextBox1.Modified)
            {
                撤消ToolStripMenuItem.Enabled = true;
            }
            else
            {
                撤消ToolStripMenuItem.Enabled = false;
            }
        }
        //设置“快捷键”中的按钮是否启用
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                剪切ToolStripMenuItem.Enabled = true;
                复制ToolStripMenuItem.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
            }
            else
            {
                剪切ToolStripMenuItem.Enabled = false;
                复制ToolStripMenuItem.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
            } 
            if (richTextBox1.Modified)
            {
                撤消ToolStripMenuItem1.Enabled = true;
            }
            else
            {
                撤消ToolStripMenuItem1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void 课堂笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           richTextBox1.Text = "";
           Name na = new Name();
           na.ShowDialog();  
           File.Create(@"C:\Users\93985\Desktop\笔记本\课堂笔记\c#\" + name + ".text");
           path = @"C:\Users\93985\Desktop\笔记本\课堂笔记\c#\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 高数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();  
            File.Create(@"C:\Users\93985\Desktop\笔记本\课堂笔记\高数\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\课堂笔记\图形学\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 图形学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();  
            File.Create(@"C:\Users\93985\Desktop\笔记本\课堂笔记\图形学\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\课堂笔记\图形学\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        
        private void 课堂笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 生活点滴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 人生哲理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\生活点滴\人生哲理\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\生活点滴\人生哲理\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 有趣的事物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\生活点滴\有趣的事物\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\生活点滴\有趣的事物\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 常识积累ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\生活点滴\常识积累\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\生活点滴\常识积累\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\生活点滴\其他\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\生活点滴\其他\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名

        }

        private void 软件工程导论ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\课堂笔记\软件工程导论\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\课堂笔记\软件工程导论\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 随行记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 大学出行记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\随行记录\大学出行记录\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\随行记录\大学出行记录\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 出行路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\随行记录\出行路线记录\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\随行记录\出行路线记录\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }

        private void 出行感触ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Text = "";
            Name na = new Name();
            na.ShowDialog();
            File.Create(@"C:\Users\93985\Desktop\笔记本\随行记录\出行感触记录\" + name + ".text");
            path = @"C:\Users\93985\Desktop\笔记本\随行记录\出行感触记录\" + name + ".text";//文件夹所在的地址
            string pathname = Path.GetFileName(path);//获取文件夹的文件名
        }
        }
        }
    

