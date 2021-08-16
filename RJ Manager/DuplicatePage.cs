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

        public DuplicatePage()
        {
            InitializeComponent();
            imageList.ImageSize = new Size(240, 180);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
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
    }
}
