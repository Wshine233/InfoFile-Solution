namespace RJ_Manager
{
    partial class ContentPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logging = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Options = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.Mo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RJInfol = new System.Windows.Forms.Label();
            this.Sizel = new System.Windows.Forms.Label();
            this.Typel = new System.Windows.Forms.Label();
            this.Namel = new System.Windows.Forms.Label();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fc1 = new System.Windows.Forms.CheckBox();
            this.fb2 = new System.Windows.Forms.Button();
            this.fb1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Options.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RJ_Manager.Properties.Resources._7cb1994b4bc96140a04f66e335f9da07;
            this.pictureBox1.Location = new System.Drawing.Point(232, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Logging
            // 
            this.Logging.AutoSize = true;
            this.Logging.Location = new System.Drawing.Point(229, 36);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(41, 12);
            this.Logging.TabIndex = 11;
            this.Logging.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 496);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.tabPage1);
            this.Options.Controls.Add(this.tabPage2);
            this.Options.Controls.Add(this.tabPage3);
            this.Options.Location = new System.Drawing.Point(232, 374);
            this.Options.Name = "Options";
            this.Options.SelectedIndex = 0;
            this.Options.Size = new System.Drawing.Size(558, 134);
            this.Options.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Options.TabIndex = 10;
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
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(447, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 9;
            this.button5.Text = "移动到工作目录";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Mo
            // 
            this.Mo.Location = new System.Drawing.Point(404, 69);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(37, 23);
            this.Mo.TabIndex = 8;
            this.Mo.Text = "补齐";
            this.Mo.UseVisualStyleBackColor = true;
            this.Mo.Click += new System.EventHandler(this.Mo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "更改/编辑RJ号";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Sizel
            // 
            this.Sizel.AutoSize = true;
            this.Sizel.Location = new System.Drawing.Point(122, 55);
            this.Sizel.Name = "Sizel";
            this.Sizel.Size = new System.Drawing.Size(95, 12);
            this.Sizel.TabIndex = 4;
            this.Sizel.Text = "文件大小：233MB";
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
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(122, 19);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(275, 12);
            this.Namel.TabIndex = 2;
            this.Namel.Text = "文件名：RJ45816askfaoi.zip (悬停查看完整路径)";
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(6, 55);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(90, 34);
            this.OpenFolder.TabIndex = 1;
            this.OpenFolder.Text = "打开文件位置";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(6, 18);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(90, 31);
            this.Open.TabIndex = 0;
            this.Open.Text = "打开文件";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(18, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "查找重复RJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "关键字过滤";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 21);
            this.textBox1.TabIndex = 8;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 44);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.fc1.CheckedChanged += new System.EventHandler(this.fc1_CheckedChanged);
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
            this.fb2.Click += new System.EventHandler(this.fb2_Click);
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
            this.fb1.Click += new System.EventHandler(this.fb1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(228, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(562, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logging);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.linkLabel1);
            this.Name = "ContentPage";
            this.Size = new System.Drawing.Size(805, 518);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Options.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}
