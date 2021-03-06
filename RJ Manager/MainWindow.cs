using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using RJ_Manager.Factories;

namespace RJ_Manager
{
    public partial class MainW : Form
    {
        public static String workDirectory;

        public MainW()
        {
            InitializeComponent();

            tabs.AddPage(TabFactory.GetNewTabPage("管理目录", TabType.Content));


            FileInfo info = new FileInfo("WorkDirectory.db");
            if (info.Exists)
            {
                StreamReader r = info.OpenText();
                workDirectory = r.ReadLine();
                r.Close();
            }
            //rjf.Clear();
        }

        private void 文件夹管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderManager fd = new FolderManager();
            fd.Show();

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabs.SelectedTab.Controls.Count >= 1)
            {
                Control ct = tabs.SelectedTab.Controls[0];

                if (ct is ContentPage)
                {
                    (ct as ContentPage).RefreshFiles();
                }
                else if(ct is DuplicatePage)
                {
                    DuplicatePage p = (DuplicatePage)ct;
                    p.RefreshFiles();
                }
                
            }
        }

        private void 设置工作文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo("WorkDirectory.db");
                info.Open(FileMode.Create).Close();
                StreamWriter writer = info.CreateText();
                workDirectory = folderBrowserDialog1.SelectedPath;
                writer.WriteLine(workDirectory);
                writer.Close();
            }
        }

        private void 打开工作文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (workDirectory != null)
            {
                DirectoryInfo info = new DirectoryInfo(workDirectory);
                if (info.Exists)
                {
                    System.Diagnostics.ProcessStartInfo inf = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                    inf.Arguments = workDirectory;
                    Process p = new Process();
                    p.StartInfo = inf;
                    p.Start();
                }
                else
                {
                    MessageBox.Show("请先指定合法的工作文件夹(可以将RJ作品快速放至工作文件夹进行处理)");
                }
            }
            else
            {
                MessageBox.Show("请先指定合法的工作文件夹(可以将RJ作品快速放至工作文件夹进行处理)");
            }
        }

        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.TopMost = !this.TopMost;
        }

        private void 置顶窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            this.TopMost = (sender as ToolStripMenuItem).Checked;
        }

        private void tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void 目录窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs.AddPage(TabFactory.GetNewTabPage("草草草草草草草草草草", TabType.Content));
        }

        private void 查重窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs.AddPage(TabFactory.GetNewTabPage("查重窗口", TabType.Duplicate));
        }
    }
}
