namespace RJ_Manager
{
    partial class MainW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件夹管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后台查询所有RJ信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工作文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置工作文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开工作文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置顶窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fb1 = new System.Windows.Forms.Button();
            this.fb2 = new System.Windows.Forms.Button();
            this.fc1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Open = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.Namel = new System.Windows.Forms.Label();
            this.Typel = new System.Windows.Forms.Label();
            this.Sizel = new System.Windows.Forms.Label();
            this.RJInfol = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.TabControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Logging = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口置顶ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 544);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.Logging);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.Options);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(805, 518);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "管理目录";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "选项";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.文件夹管理ToolStripMenuItem,
            this.大图标模式ToolStripMenuItem,
            this.后台查询所有RJ信息ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.工作文件夹ToolStripMenuItem,
            this.置顶窗口ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "选项";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 文件夹管理ToolStripMenuItem
            // 
            this.文件夹管理ToolStripMenuItem.Name = "文件夹管理ToolStripMenuItem";
            this.文件夹管理ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.文件夹管理ToolStripMenuItem.Text = "文件夹管理";
            // 
            // 大图标模式ToolStripMenuItem
            // 
            this.大图标模式ToolStripMenuItem.Name = "大图标模式ToolStripMenuItem";
            this.大图标模式ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.大图标模式ToolStripMenuItem.Text = "大图标模式";
            // 
            // 后台查询所有RJ信息ToolStripMenuItem
            // 
            this.后台查询所有RJ信息ToolStripMenuItem.Name = "后台查询所有RJ信息ToolStripMenuItem";
            this.后台查询所有RJ信息ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.后台查询所有RJ信息ToolStripMenuItem.Text = "后台查询所有RJ信息";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 工作文件夹ToolStripMenuItem
            // 
            this.工作文件夹ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置工作文件夹ToolStripMenuItem,
            this.打开工作文件夹ToolStripMenuItem});
            this.工作文件夹ToolStripMenuItem.Name = "工作文件夹ToolStripMenuItem";
            this.工作文件夹ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.工作文件夹ToolStripMenuItem.Text = "工作文件夹";
            // 
            // 设置工作文件夹ToolStripMenuItem
            // 
            this.设置工作文件夹ToolStripMenuItem.Name = "设置工作文件夹ToolStripMenuItem";
            this.设置工作文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.设置工作文件夹ToolStripMenuItem.Text = "设置工作文件夹";
            // 
            // 打开工作文件夹ToolStripMenuItem
            // 
            this.打开工作文件夹ToolStripMenuItem.Name = "打开工作文件夹ToolStripMenuItem";
            this.打开工作文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开工作文件夹ToolStripMenuItem.Text = "打开工作文件夹";
            // 
            // 置顶窗口ToolStripMenuItem
            // 
            this.置顶窗口ToolStripMenuItem.Name = "置顶窗口ToolStripMenuItem";
            this.置顶窗口ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.置顶窗口ToolStripMenuItem.Text = "置顶窗口";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(224, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(562, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.fc1);
            this.tabPage3.Controls.Add(this.fb2);
            this.tabPage3.Controls.Add(this.fb1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 108);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "过滤器";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fb1
            // 
            this.fb1.Location = new System.Drawing.Point(10, 15);
            this.fb1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.fb1.Name = "fb1";
            this.fb1.Size = new System.Drawing.Size(53, 46);
            this.fb1.TabIndex = 0;
            this.fb1.Text = "有RJ";
            this.fb1.UseVisualStyleBackColor = true;
            // 
            // fb2
            // 
            this.fb2.BackColor = System.Drawing.Color.Transparent;
            this.fb2.Location = new System.Drawing.Point(83, 15);
            this.fb2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.fb2.Name = "fb2";
            this.fb2.Size = new System.Drawing.Size(53, 46);
            this.fb2.TabIndex = 1;
            this.fb2.Text = "无RJ";
            this.fb2.UseVisualStyleBackColor = false;
            // 
            // fc1
            // 
            this.fc1.AutoSize = true;
            this.fc1.Checked = true;
            this.fc1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fc1.Location = new System.Drawing.Point(453, 48);
            this.fc1.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.fc1.Name = "fc1";
            this.fc1.Size = new System.Drawing.Size(84, 16);
            this.fc1.TabIndex = 2;
            this.fc1.Text = "保留模糊RJ";
            this.fc1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(453, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "时间过滤";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 44);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "从";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "至";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 21);
            this.textBox1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "关键字过滤";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 108);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "操作";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(18, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "查找重复RJ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(145, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "查找无RJ文件";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(272, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "管理扫描白名单";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.Mo);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.RJInfol);
            this.tabPage1.Controls.Add(this.Sizel);
            this.tabPage1.Controls.Add(this.Typel);
            this.tabPage1.Controls.Add(this.Namel);
            this.tabPage1.Controls.Add(this.OpenFolder);
            this.tabPage1.Controls.Add(this.Open);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(6, 18);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(90, 31);
            this.Open.TabIndex = 0;
            this.Open.Text = "打开文件";
            this.Open.UseVisualStyleBackColor = true;
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(6, 55);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(90, 34);
            this.OpenFolder.TabIndex = 1;
            this.OpenFolder.Text = "打开文件位置";
            this.OpenFolder.UseVisualStyleBackColor = true;
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(122, 19);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(275, 12);
            this.Namel.TabIndex = 2;
            this.Namel.Text = "文件名：RJ45816askfaoi.zip (悬停查看完整路径)";
            // 
            // Typel
            // 
            this.Typel.AutoSize = true;
            this.Typel.Location = new System.Drawing.Point(122, 37);
            this.Typel.Name = "Typel";
            this.Typel.Size = new System.Drawing.Size(65, 12);
            this.Typel.TabIndex = 3;
            this.Typel.Text = "创建时间：";
            // 
            // Sizel
            // 
            this.Sizel.AutoSize = true;
            this.Sizel.Location = new System.Drawing.Point(122, 55);
            this.Sizel.Name = "Sizel";
            this.Sizel.Size = new System.Drawing.Size(95, 12);
            this.Sizel.TabIndex = 4;
            this.Sizel.Text = "文件大小：233MB";
            // 
            // RJInfol
            // 
            this.RJInfol.AutoSize = true;
            this.RJInfol.Location = new System.Drawing.Point(122, 73);
            this.RJInfol.Name = "RJInfol";
            this.RJInfol.Size = new System.Drawing.Size(53, 12);
            this.RJInfol.TabIndex = 5;
            this.RJInfol.Text = "RJ信息：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "RJ45816",
            "RJ23333"});
            this.comboBox1.Location = new System.Drawing.Point(181, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "更改/编辑RJ号";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Mo
            // 
            this.Mo.Location = new System.Drawing.Point(404, 69);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(37, 23);
            this.Mo.TabIndex = 8;
            this.Mo.Text = "补齐";
            this.Mo.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(447, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 9;
            this.button5.Text = "移动到工作目录";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.tabPage1);
            this.Options.Controls.Add(this.tabPage2);
            this.Options.Controls.Add(this.tabPage3);
            this.Options.Location = new System.Drawing.Point(228, 372);
            this.Options.Name = "Options";
            this.Options.SelectedIndex = 0;
            this.Options.Size = new System.Drawing.Size(558, 134);
            this.Options.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Options.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 496);
            this.listBox1.TabIndex = 0;
            // 
            // Logging
            // 
            this.Logging.AutoSize = true;
            this.Logging.Location = new System.Drawing.Point(225, 34);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(41, 12);
            this.Logging.TabIndex = 6;
            this.Logging.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RJ_Manager.Properties.Resources._7cb1994b4bc96140a04f66e335f9da07;
            this.pictureBox1.Location = new System.Drawing.Point(228, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(812, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "MainW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RJ管理目录";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainW_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件夹管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后台查询所有RJ信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工作文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置工作文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开工作文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置顶窗口ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logging;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl Options;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Mo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label RJInfol;
        private System.Windows.Forms.Label Sizel;
        private System.Windows.Forms.Label Typel;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox fc1;
        private System.Windows.Forms.Button fb2;
        private System.Windows.Forms.Button fb1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}