using RJ_Manager.InfoFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager
{
    public partial class Form5 : Form
    {
        public struct ListPack
        {
            public Object sender;
            public List<Object> co;

            public ListPack(Object sender, List<Object> co)
            {
                this.sender = sender;
                this.co = co;
            }
        }

        public List<Object> RJList;

        public Form5(List<Object> co)
        {
            InitializeComponent();
            listView1.Items.Clear();
            RJList = co;
        }

        public void finding(Object pack)
        {
            Object sender = ((ListPack)pack).sender;
            List<Object> co = ((ListPack)pack).co;

            Dictionary<String, List<RJFile>> x = new Dictionary<string, List<RJFile>>();
            foreach(Object o in co)
            {
                RJFile c = (o as ContentPage.ListInfo).File;
                String[] rjs = c.RJ.Split(',');
                foreach(String xx in rjs)
                {
                    if(xx == "?") { continue; }
                    if (x.ContainsKey(xx))
                    {
                        x[xx].Add(c);
                    }
                    else
                    {
                        x.Add(xx, new List<RJFile>());
                        x[xx].Add(c);
                    }
                }
            }
            bool a = false;
            foreach (KeyValuePair<String, List<RJFile>> k in x)
            {
                if (k.Value.Count > 1)
                {
                    foreach (RJFile d in k.Value)
                    {
                        FileInfo info = new FileInfo(d.fullPath);
                        if (!info.Exists) continue;
                        ListViewItem item = new ListViewItem();
                        item.Text = info.Name;
                        item.SubItems.Add(k.Key);
                        item.SubItems.Add(Utils.FileSize(info.Length));
                        item.SubItems.Add(d.RJ);
                        item.SubItems.Add(d.fullPath);
                        item.BackColor = a ? Color.FromArgb(0xE9E6FF) : Color.White;
                        
                        this.Invoke((EventHandler)
                        (delegate
                        {
                            if (!(sender as ListView).IsHandleCreated) { return; }
                            (sender as ListView).Items.Add(item);
                        })
                        );
                    }
                    a = !a;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Thread a = new Thread(new ParameterizedThreadStart(finding));
            a.Start(new ListPack(listView1, RJList));
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            System.Windows.Forms.ListView lv = sender as System.Windows.Forms.ListView;
            if ((lv.ListViewItemSorter as ListViewColumnSorter) == null)
                lv.ListViewItemSorter = new ListViewColumnSorter();
            ListViewColumnSorter temp = (lv.ListViewItemSorter as ListViewColumnSorter);
            temp.StringNumOrder = true;
            if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                if ((lv.ListViewItemSorter as ListViewColumnSorter).OrderType == SortOrder.Ascending)
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Descending;
                }
                else
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Ascending;
                }
            }
            else
            {
                (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Ascending;
            }
            ((ListView)sender).Sort();
            if(e.Column != 1) { return; }
            String k = "";
            bool a = false;
            Color c = Color.White;
            foreach(ListViewItem x in listView1.Items)
            {
                if (k != x.SubItems[1].Text)
                {
                    x.BackColor = a ? Color.FromArgb(0xE9E6FF) : Color.White;
                    a = !a;
                    k = x.SubItems[1].Text;
                    c = x.BackColor;
                }
                else
                {
                    x.BackColor = c;
                }
            }
        }

        private void 把选中项移至回收站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems.Count.ToString());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
