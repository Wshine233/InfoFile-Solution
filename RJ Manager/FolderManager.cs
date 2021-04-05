using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager
{
    public partial class FolderManager : Form
    {

        public FolderManager()
        {
            InitializeComponent();
            checkedListBox1.Items.Clear();
            foreach (String line in loadList())
            {
                checkedListBox1.Items.Add(line);
            }
        }

        public static List<String> loadList()
        {
            List<String> list = new List<string>();
            FileInfo f = new FileInfo("folders.db");
            if (!f.Exists)
            {
                f.Create();
            }

            StreamReader sr = f.OpenText();
            String line;
            while( (line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectFolder.ShowDialog().Equals(DialogResult.OK) && !checkedListBox1.Items.Contains(SelectFolder.SelectedPath))
            {
                checkedListBox1.Items.Add(SelectFolder.SelectedPath, false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo("folders.db");
            if (f.Exists)
            {
                f.Delete();
            }
            f.Create().Close();

            StreamWriter sw = f.CreateText();
            foreach(String line in checkedListBox1.Items)
            {
                sw.WriteLine(line);
            }
            sw.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("警告", "你确定将选中项从列表移除吗？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                List<String> index = new List<String>();
                foreach (String f in checkedListBox1.CheckedItems)
                {
                    index.Add(f);
                }
                foreach (String f in index)
                {
                    checkedListBox1.Items.Remove(f);
                }
            }
            
        }
    }
}
