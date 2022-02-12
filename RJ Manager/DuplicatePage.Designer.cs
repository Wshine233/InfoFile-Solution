
namespace RJ_Manager
{
    partial class DuplicatePage
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "123123",
            "233"}, -1);
            this.listView1 = new RJ_Manager.CustomControls.ListViewExtended();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.双击选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示RJ信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol});
            this.listView1.ContextMenuStrip = this.viewMenu;
            this.listView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(14, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(777, 493);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(240, 180);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // NameCol
            // 
            this.NameCol.Text = "文件名";
            // 
            // viewMenu
            // 
            this.viewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.双击选项ToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // 双击选项ToolStripMenuItem
            // 
            this.双击选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.显示RJ信息ToolStripMenuItem});
            this.双击选项ToolStripMenuItem.Name = "双击选项ToolStripMenuItem";
            this.双击选项ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.双击选项ToolStripMenuItem.Text = "双击选项";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Checked = true;
            this.打开文件ToolStripMenuItem.CheckOnClick = true;
            this.打开文件ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 显示RJ信息ToolStripMenuItem
            // 
            this.显示RJ信息ToolStripMenuItem.CheckOnClick = true;
            this.显示RJ信息ToolStripMenuItem.Name = "显示RJ信息ToolStripMenuItem";
            this.显示RJ信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.显示RJ信息ToolStripMenuItem.Text = "显示RJ信息";
            this.显示RJ信息ToolStripMenuItem.Click += new System.EventHandler(this.显示RJ信息ToolStripMenuItem_Click);
            // 
            // DuplicatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "DuplicatePage";
            this.Padding = new System.Windows.Forms.Padding(14, 11, 14, 14);
            this.Size = new System.Drawing.Size(805, 518);
            this.viewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ListView listView1;
        private RJ_Manager.CustomControls.ListViewExtended listView1;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ContextMenuStrip viewMenu;
        private System.Windows.Forms.ToolStripMenuItem 双击选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示RJ信息ToolStripMenuItem;
    }
}
