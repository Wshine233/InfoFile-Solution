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

        public Dictionary<String, List<RJFile>> dic = new Dictionary<string, List<RJFile>>();

        public DuplicatePage()
        {
            InitializeComponent();
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
                    }
                    dic[rj].Add(f);
                }
            }

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
                        ListViewItem item = new ListViewItem(f.fullPath.Substring(f.fullPath.LastIndexOf('\\') + 1), group);
                        item.Tag = f;
                        listView1.Items.Add(item);
                    }
                }
            }
        }
    }
}
