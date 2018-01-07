namespace note
{
    partial class Form1
    {

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课堂笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件工程导论ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生活点滴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人生哲理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有趣的人和事ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常识积累ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随行记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大学城出行记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出行路线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出行感触ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助主题HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.关于记事本AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.撤消ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(392, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课堂笔记ToolStripMenuItem,
            this.生活点滴ToolStripMenuItem,
            this.随行记录ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新建ToolStripMenuItem.Text = "新建(&N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 课堂笔记ToolStripMenuItem
            // 
            this.课堂笔记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.高数ToolStripMenuItem,
            this.图形学ToolStripMenuItem,
            this.软件工程导论ToolStripMenuItem});
            this.课堂笔记ToolStripMenuItem.Name = "课堂笔记ToolStripMenuItem";
            this.课堂笔记ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课堂笔记ToolStripMenuItem.Text = "课堂笔记";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cToolStripMenuItem.Text = "c#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // 高数ToolStripMenuItem
            // 
            this.高数ToolStripMenuItem.Name = "高数ToolStripMenuItem";
            this.高数ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.高数ToolStripMenuItem.Text = "高数";
            this.高数ToolStripMenuItem.Click += new System.EventHandler(this.高数ToolStripMenuItem_Click);
            // 
            // 图形学ToolStripMenuItem
            // 
            this.图形学ToolStripMenuItem.Name = "图形学ToolStripMenuItem";
            this.图形学ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图形学ToolStripMenuItem.Text = "图形学";
            this.图形学ToolStripMenuItem.Click += new System.EventHandler(this.图形学ToolStripMenuItem_Click);
            // 
            // 软件工程导论ToolStripMenuItem
            // 
            this.软件工程导论ToolStripMenuItem.Name = "软件工程导论ToolStripMenuItem";
            this.软件工程导论ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.软件工程导论ToolStripMenuItem.Text = "软件工程导论";
            this.软件工程导论ToolStripMenuItem.Click += new System.EventHandler(this.软件工程导论ToolStripMenuItem_Click);
            // 
            // 生活点滴ToolStripMenuItem
            // 
            this.生活点滴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人生哲理ToolStripMenuItem,
            this.有趣的人和事ToolStripMenuItem,
            this.常识积累ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.生活点滴ToolStripMenuItem.Name = "生活点滴ToolStripMenuItem";
            this.生活点滴ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.生活点滴ToolStripMenuItem.Text = "生活点滴";
            this.生活点滴ToolStripMenuItem.Click += new System.EventHandler(this.生活点滴ToolStripMenuItem_Click);
            // 
            // 人生哲理ToolStripMenuItem
            // 
            this.人生哲理ToolStripMenuItem.Name = "人生哲理ToolStripMenuItem";
            this.人生哲理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.人生哲理ToolStripMenuItem.Text = "人生哲理";
            this.人生哲理ToolStripMenuItem.Click += new System.EventHandler(this.人生哲理ToolStripMenuItem_Click);
            // 
            // 有趣的人和事ToolStripMenuItem
            // 
            this.有趣的人和事ToolStripMenuItem.Name = "有趣的人和事ToolStripMenuItem";
            this.有趣的人和事ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.有趣的人和事ToolStripMenuItem.Text = "有趣的事物";
            this.有趣的人和事ToolStripMenuItem.Click += new System.EventHandler(this.有趣的事物ToolStripMenuItem_Click);
            // 
            // 常识积累ToolStripMenuItem
            // 
            this.常识积累ToolStripMenuItem.Name = "常识积累ToolStripMenuItem";
            this.常识积累ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.常识积累ToolStripMenuItem.Text = "常识积累";
            this.常识积累ToolStripMenuItem.Click += new System.EventHandler(this.常识积累ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.其他ToolStripMenuItem.Text = "其他";
            this.其他ToolStripMenuItem.Click += new System.EventHandler(this.其他ToolStripMenuItem_Click);
            // 
            // 随行记录ToolStripMenuItem
            // 
            this.随行记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大学城出行记录ToolStripMenuItem,
            this.出行路线ToolStripMenuItem,
            this.出行感触ToolStripMenuItem});
            this.随行记录ToolStripMenuItem.Name = "随行记录ToolStripMenuItem";
            this.随行记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.随行记录ToolStripMenuItem.Text = "随行记录";
            this.随行记录ToolStripMenuItem.Click += new System.EventHandler(this.随行记录ToolStripMenuItem_Click);
            // 
            // 大学城出行记录ToolStripMenuItem
            // 
            this.大学城出行记录ToolStripMenuItem.Name = "大学城出行记录ToolStripMenuItem";
            this.大学城出行记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.大学城出行记录ToolStripMenuItem.Text = "大学出行记录";
            this.大学城出行记录ToolStripMenuItem.Click += new System.EventHandler(this.大学出行记录ToolStripMenuItem_Click);
            // 
            // 出行路线ToolStripMenuItem
            // 
            this.出行路线ToolStripMenuItem.Name = "出行路线ToolStripMenuItem";
            this.出行路线ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.出行路线ToolStripMenuItem.Text = "出行路线记录";
            this.出行路线ToolStripMenuItem.Click += new System.EventHandler(this.出行路线ToolStripMenuItem_Click);
            // 
            // 出行感触ToolStripMenuItem
            // 
            this.出行感触ToolStripMenuItem.Name = "出行感触ToolStripMenuItem";
            this.出行感触ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.出行感触ToolStripMenuItem.Text = "出行感触记录";
            this.出行感触ToolStripMenuItem.Click += new System.EventHandler(this.出行感触ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.open_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.saveWhere_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消ToolStripMenuItem,
            this.toolStripSeparator4,
            this.剪切XToolStripMenuItem,
            this.复制VToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除DToolStripMenuItem,
            this.toolStripSeparator5});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 撤消ToolStripMenuItem
            // 
            this.撤消ToolStripMenuItem.Enabled = false;
            this.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem";
            this.撤消ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.撤消ToolStripMenuItem.Text = "撤消(&U)";
            this.撤消ToolStripMenuItem.Click += new System.EventHandler(this.return_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // 剪切XToolStripMenuItem
            // 
            this.剪切XToolStripMenuItem.Enabled = false;
            this.剪切XToolStripMenuItem.Name = "剪切XToolStripMenuItem";
            this.剪切XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切XToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.剪切XToolStripMenuItem.Text = "剪切(&T)";
            this.剪切XToolStripMenuItem.Click += new System.EventHandler(this.剪切XToolStripMenuItem_Click);
            // 
            // 复制VToolStripMenuItem
            // 
            this.复制VToolStripMenuItem.Enabled = false;
            this.复制VToolStripMenuItem.Name = "复制VToolStripMenuItem";
            this.复制VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制VToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.复制VToolStripMenuItem.Text = "复制(&C)";
            this.复制VToolStripMenuItem.Click += new System.EventHandler(this.复制VToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴(&P)";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Enabled = false;
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.删除DToolStripMenuItem.Text = "删除(&L)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行WToolStripMenuItem,
            this.字体FToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 21);
            this.toolStripMenuItem1.Text = "格式(&O)";
            // 
            // 自动换行WToolStripMenuItem
            // 
            this.自动换行WToolStripMenuItem.Checked = true;
            this.自动换行WToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行WToolStripMenuItem.Name = "自动换行WToolStripMenuItem";
            this.自动换行WToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.自动换行WToolStripMenuItem.Text = "自动换行(&W)";
            this.自动换行WToolStripMenuItem.Click += new System.EventHandler(this.自动换行WToolStripMenuItem_Click);
            // 
            // 字体FToolStripMenuItem
            // 
            this.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem";
            this.字体FToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.字体FToolStripMenuItem.Text = "字体(&F)";
            this.字体FToolStripMenuItem.Click += new System.EventHandler(this.font_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 21);
            this.toolStripMenuItem2.Text = "查看(&V)";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.Checked = true;
            this.状态栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.状态栏ToolStripMenuItem.Text = "状态栏(&S)";
            this.状态栏ToolStripMenuItem.Click += new System.EventHandler(this.状态栏ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助主题HToolStripMenuItem,
            this.toolStripSeparator7,
            this.关于记事本AToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(61, 21);
            this.toolStripMenuItem3.Text = "帮助(&H)";
            // 
            // 帮助主题HToolStripMenuItem
            // 
            this.帮助主题HToolStripMenuItem.Name = "帮助主题HToolStripMenuItem";
            this.帮助主题HToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助主题HToolStripMenuItem.Text = "帮助主题(&H)";
            this.帮助主题HToolStripMenuItem.Click += new System.EventHandler(this.帮助主题HToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // 关于记事本AToolStripMenuItem
            // 
            this.关于记事本AToolStripMenuItem.Name = "关于记事本AToolStripMenuItem";
            this.关于记事本AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于记事本AToolStripMenuItem.Text = "关于记事本(&A)";
            this.关于记事本AToolStripMenuItem.Click += new System.EventHandler(this.关于记事本AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel3.Text = "就绪";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(332, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "显示时间/日期";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(399, 314);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消ToolStripMenuItem1,
            this.toolStripSeparator8,
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem1,
            this.删除ToolStripMenuItem,
            this.toolStripSeparator9,
            this.全选AToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 148);
            this.contextMenuStrip1.TabStop = true;
            this.contextMenuStrip1.Text = "contextMenuStrip1";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 撤消ToolStripMenuItem1
            // 
            this.撤消ToolStripMenuItem1.Enabled = false;
            this.撤消ToolStripMenuItem1.Name = "撤消ToolStripMenuItem1";
            this.撤消ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.撤消ToolStripMenuItem1.Text = "撤消(&U)";
            this.撤消ToolStripMenuItem1.Click += new System.EventHandler(this.return_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(114, 6);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Enabled = false;
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.剪切ToolStripMenuItem.Text = "剪切(&X)";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切XToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Enabled = false;
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.复制ToolStripMenuItem.Text = "复制(&C)";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制VToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem1
            // 
            this.粘贴ToolStripMenuItem1.Name = "粘贴ToolStripMenuItem1";
            this.粘贴ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.粘贴ToolStripMenuItem1.Text = "粘贴(&V)";
            this.粘贴ToolStripMenuItem1.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Enabled = false;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.删除ToolStripMenuItem.Text = "删除(&D)";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(114, 6);
            // 
            // 全选AToolStripMenuItem1
            // 
            this.全选AToolStripMenuItem1.Name = "全选AToolStripMenuItem1";
            this.全选AToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.全选AToolStripMenuItem1.Text = "全选(&A)";
            this.全选AToolStripMenuItem1.Click += new System.EventHandler(this.全选AToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 364);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三人行记事本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 剪切XToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制VToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        public System.Windows.Forms.ToolStripMenuItem 自动换行WToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 字体FToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 帮助主题HToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 关于记事本AToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        public System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        public System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 课堂笔记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生活点滴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人生哲理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有趣的人和事ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常识积累ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件工程导论ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随行记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大学城出行记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出行路线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出行感触ToolStripMenuItem;




    }
}

