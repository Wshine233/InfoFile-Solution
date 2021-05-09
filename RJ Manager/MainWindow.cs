using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Text;
using RJ_Manager.Factories;

namespace RJ_Manager
{
    public partial class MainW : Form
    {
        public static String workDirectory;
        public struct RJFile
        {
            public String RJ;
            public String fullPath;
            public bool? fuzzy;
        };
        
        //public static Dictionary<int,RJFile> rjf = new Dictionary<int, RJFile>();

        public struct Pack
        {
            public String url;
            public bool refresh;
            public String rj;
        };

        public class ListInfo
        {
            String name;
            int num;
            RJFile? file;
            
            public RJFile File
            {
                get
                {
                    if(file != null)
                    {
                        return (RJFile)file;
                    }
                    else
                    {
                        RJFile c;
                        c.RJ = "?";
                        c.fullPath = "";
                        c.fuzzy = null;
                        return c;
                    }
                }


            }

            public ListInfo(String name, int num, RJFile? file)
            {
                this.name = name;
                this.num = num;
                this.file = file;
            }

            public override string ToString()
            {
                return name;
            }

            public int getNum()
            {
                return this.num;
            }


        }

        public static List<Object> co = new List<object>();
        private String now_url = "";       //被要求加载的url
        Thread picDownloader = null;   //下载线程

        public MainW()
        {
            InitializeComponent();

            tabs.TabPages.Add(TabFactory.GetNewTabPage("管理目录", TabType.Content));


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
            if(tabs.SelectedTab.Controls.Count == 1 && tabs.SelectedTab.Controls[0] is ContentPage)
            {
                (tabs.SelectedTab.Controls[0] as ContentPage).RefreshFiles();
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
            if (workDirectory.Length > 0)
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
    }
}
