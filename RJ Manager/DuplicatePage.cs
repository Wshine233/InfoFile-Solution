using RJ_Manager.CustomControls;
using RJ_Manager.HTMLProcesser;
using RJ_Manager.InfoFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager
{
    public partial class DuplicatePage : UserControl
    {

        public Dictionary<String, List<RJFile>> dic = new Dictionary<String, List<RJFile>>();
        public ImageList imageList = new ImageList();

        public enum DoubleClickAction
        {
            OpenFile,
            ViewRJInfo
        }

        private DoubleClickAction doubleClickMode = DoubleClickAction.OpenFile;

        public DuplicatePage()
        {
            InitializeComponent();
            imageList.ImageSize = new Size(240, 180);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            this.listView1.SetGroupState(ListViewGroupState.Hidden);

            ToolStripMenuItem dclick = viewMenu.Items[0] as ToolStripMenuItem;
            dclick.DropDownItems[0].Tag = dclick.DropDownItems[1] as ToolStripMenuItem;
            dclick.DropDownItems[1].Tag = dclick.DropDownItems[0] as ToolStripMenuItem;

        }

        public void RefreshFiles()
        {
            dic.Clear();
            RJFile f;

            foreach (FileInfo info in Utils.ScanFiles())
            {
                f = new RJFile(info);

                foreach (String rj in f.RJ.Split(new String[]{ "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!dic.ContainsKey(rj))
                    {
                        dic.Add(rj, new List<RJFile>());
                        imageList.Images.Add(rj, HTMLHelper.GetRJImage(rj));
                    }
                    dic[rj].Add(f);
                }
            }
            listView1.LargeImageList = imageList;

            RefreshViewer();
        }

        public void RefreshViewer()
        {
            listView1.Clear();
            listView1.Items.Clear();
            listView1.Groups.Clear();

            foreach (String rj in dic.Keys)
            {
                ListViewGroup group = new ListViewGroup(rj);
                if (!listView1.Groups.Contains(group))
                {
                    listView1.Groups.Add(group);

                    foreach(RJFile f in dic[rj])
                    {
                        ListViewItem item = new ListViewItem(f.fullPath.Substring(f.fullPath.LastIndexOf('\\') + 1), rj, group);
                        item.Tag = f;
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;

            if(doubleClickMode == DoubleClickAction.OpenFile)
            {
                foreach(ListViewItem item in lv.SelectedItems)
                {
                    if (item.Tag as RJFile != null)
                    {
                        FileInfo info = new FileInfo((item.Tag as RJFile).fullPath);
                        if (info.Exists)
                        {
                            System.Diagnostics.Process.Start((item.Tag as RJFile).fullPath);
                        }
                    }
                }
            }
            else
            {

            }
            
            
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Checked)  // 此时选中状态已经被切换
            {
                doubleClickMode = DoubleClickAction.OpenFile;
                (item.Tag as ToolStripMenuItem).CheckState = CheckState.Unchecked;
            }
            else
            {
                doubleClickMode = DoubleClickAction.ViewRJInfo;
                (item.Tag as ToolStripMenuItem).CheckState = CheckState.Checked;
            }
        }

        private void 显示RJ信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Checked)  // 此时选中状态已经被切换
            {
                doubleClickMode = DoubleClickAction.OpenFile;
                (item.Tag as ToolStripMenuItem).CheckState = CheckState.Unchecked;
            }
            else
            {
                doubleClickMode = DoubleClickAction.ViewRJInfo;
                (item.Tag as ToolStripMenuItem).CheckState = CheckState.Checked;
            }
        }
    }
}
