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
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.新窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.目录窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new RJ_Manager.CustomControls.WebTab();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.新窗口ToolStripMenuItem});
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
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 文件夹管理ToolStripMenuItem
            // 
            this.文件夹管理ToolStripMenuItem.Name = "文件夹管理ToolStripMenuItem";
            this.文件夹管理ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.文件夹管理ToolStripMenuItem.Text = "文件夹管理";
            this.文件夹管理ToolStripMenuItem.Click += new System.EventHandler(this.文件夹管理ToolStripMenuItem_Click);
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
            this.设置工作文件夹ToolStripMenuItem.Click += new System.EventHandler(this.设置工作文件夹ToolStripMenuItem_Click);
            // 
            // 打开工作文件夹ToolStripMenuItem
            // 
            this.打开工作文件夹ToolStripMenuItem.Name = "打开工作文件夹ToolStripMenuItem";
            this.打开工作文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开工作文件夹ToolStripMenuItem.Text = "打开工作文件夹";
            this.打开工作文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开工作文件夹ToolStripMenuItem_Click);
            // 
            // 置顶窗口ToolStripMenuItem
            // 
            this.置顶窗口ToolStripMenuItem.Name = "置顶窗口ToolStripMenuItem";
            this.置顶窗口ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.置顶窗口ToolStripMenuItem.Text = "置顶窗口";
            this.置顶窗口ToolStripMenuItem.Click += new System.EventHandler(this.置顶窗口ToolStripMenuItem_Click);
            // 
            // 新窗口ToolStripMenuItem
            // 
            this.新窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.目录窗口ToolStripMenuItem});
            this.新窗口ToolStripMenuItem.Name = "新窗口ToolStripMenuItem";
            this.新窗口ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.新窗口ToolStripMenuItem.Text = "新窗口";
            // 
            // 目录窗口ToolStripMenuItem
            // 
            this.目录窗口ToolStripMenuItem.Name = "目录窗口ToolStripMenuItem";
            this.目录窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.目录窗口ToolStripMenuItem.Text = "目录窗口";
            this.目录窗口ToolStripMenuItem.Click += new System.EventHandler(this.目录窗口ToolStripMenuItem_Click);
            // 
            // tabs
            // 
            this.tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabs.ItemSize = new System.Drawing.Size(55, 0);
            this.tabs.Location = new System.Drawing.Point(0, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(813, 544);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 9;
            this.tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabs_DrawItem);
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(812, 570);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "MainW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RJ管理目录";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private CustomControls.WebTab tabs;
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
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem 新窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 目录窗口ToolStripMenuItem;
    }
}