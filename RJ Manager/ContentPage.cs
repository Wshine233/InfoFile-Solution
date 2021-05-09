using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RJ_Manager
{
    public partial class ContentPage : UserControl
    {
        public ContentPage()
        {
            InitializeComponent();
            button1.Enabled = false;
            FileInfo info = new FileInfo("WorkDirectory.db");
            if (info.Exists)
            {
                StreamReader r = info.OpenText();
                workDirectory = r.ReadLine();
                r.Close();
            }
            //rjf.Clear();
        }

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
                    if (file != null)
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

        int lastIndex = -1;
        int lastLastIndex = -1;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            pictureBox1.Image = null;
            linkLabel1.Text = "?";
            if ((listBox1.SelectedItem as ListInfo).File.RJ == "?")
            {
                loadInfo("");
                button1.Enabled = true;
                button5.Enabled = false;
                return;
            }

            button5.Enabled = true;
            String[] s = (listBox1.SelectedItem as ListInfo).File.RJ.Split(',');
            foreach (String ss in s)
            {
                comboBox1.Items.Add(ss);
            }
            comboBox1.SelectedItem = s[0];
            button1.Enabled = true;
            loadInfo(s[0]);

        }

        private void loadInfo(String rj)
        {
            loadInfo(rj, false);
        }

        private void loadInfo(String rj, bool shouldCheckRefresh)
        {
            loadInfo(rj, shouldCheckRefresh, false);
        }

        private void loadInfo(String rj, bool shouldCheckRefresh, bool forceRefresh)
        {
            toolTip1.SetToolTip(linkLabel1, "Loading...");
            /*while (picDownloader != null && (picDownloader.ThreadState.Equals(System.Threading.ThreadState.AbortRequested) || picDownloader.ThreadState.Equals(System.Threading.ThreadState.WaitSleepJoin)))
            {

            }
            if (picDownloader != null && picDownloader.IsAlive)
            {
                picDownloader.Abort();
            }*/
            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            if ((listBox1.SelectedItem as ListInfo).File.RJ == "?")
            {
                this.now_url = "-";
                //return; 
            }


            if ((listBox1.SelectedItem as ListInfo).getNum() < 0) { return; }
            FileInfo info = new FileInfo((listBox1.SelectedItem as ListInfo).File.fullPath);
            if (!info.Exists)
            {
                MessageBox.Show("文件已被删除、重命名或移动", "找不到文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button5.Enabled = false;
                return;
            }
            Namel.Text = "文件名：" + info.Name;
            Typel.Text = "创建时间：" + info.CreationTime;
            Sizel.Text = "文件大小：" + fileSize(info.Length);

            if ((listBox1.SelectedItem as ListInfo).File.RJ == "?" || rj == "") { return; }

            linkLabel1.Text = (listBox1.SelectedItem as ListInfo).File.RJ;
            this.now_url = "https://img.dlsite.jp/modpub/images2/work/doujin/RJ" + (int.Parse(rj.Substring(2, 3)) + 1).ToString("000") + "000/" + rj + "_img_main.jpg";
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
            pictureBox1.Image = Resources.Resource1.Wait;

            picDownloader = new Thread(new ParameterizedThreadStart(loadPicAsync)); //下载线程
            Pack k;
            k.refresh = ((forceRefresh && (MessageBox.Show(this, "是否删除缓存？建议只在异常时使用！", "警告", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))) || (shouldCheckRefresh && (lastIndex == listBox1.SelectedIndex) && (lastLastIndex == listBox1.SelectedIndex) && (MessageBox.Show(this, "是否删除缓存？建议只在异常时使用！", "警告", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))));
            k.url = now_url;
            k.rj = rj;
            if (shouldCheckRefresh)
            {
                if ((lastIndex == listBox1.SelectedIndex) && (lastLastIndex == listBox1.SelectedIndex))
                {
                    lastLastIndex = -1;
                    lastIndex = -1;
                }
                else
                {
                    lastLastIndex = lastIndex;
                    lastIndex = listBox1.SelectedIndex;
                }

            }

            picDownloader.Start(k);

        }

        private void loadPicAsync(object pack)
        {
            try
            {
                Pack p = (Pack)pack;

                if (this.now_url != p.url)
                {
                    Thread.CurrentThread.Abort();
                }

                WebClient a = new WebClient();

                DirectoryInfo dirInfo = new DirectoryInfo("CachePic");
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                FileInfo inf = new FileInfo("CachePic\\" + p.url.Substring(p.url.LastIndexOf("/") + 1, 8) + ".html");
                String docs;
                if (inf.Exists && !p.refresh)
                {
                    Utils.decrypt(inf, "RJ");
                    StreamReader r = inf.OpenText();
                    docs = r.ReadToEnd();
                    r.Close();
                    Utils.encrypt(inf, "RJ");
                }
                else
                {
                    byte[] document = a.DownloadData("https://www.dlsite.com/maniax/work/=/product_id/" + p.rj + ".html");
                    docs = Encoding.UTF8.GetString(document);
                    inf.Open(FileMode.Create).Close();
                    StreamWriter wr = inf.CreateText();
                    wr.Write(docs);
                    wr.Close();
                    Utils.encrypt(inf, "RJ");
                }

                String name = docs.Substring(docs.IndexOf("<h1 itemprop=\"name\" id=\"work_name\">"), docs.IndexOf("</h1>") - docs.IndexOf("<h1 itemprop=\"name\" id=\"work_name\">") + 1);
                //MessageBox.Show(name);
                name = name.Substring(name.IndexOf("one-link-mark=\"yes\">") + 20, name.LastIndexOf("</a>") - name.IndexOf("one-link-mark=\"yes\">") - 20);
                name = name.Substring(name.LastIndexOf('>') + 1);
                //MessageBox.Show(name);
                if (this.now_url != p.url)
                {

                    Thread.CurrentThread.Abort();
                }
                else
                {
                    this.Invoke((EventHandler)
                    (delegate
                    {
                        linkLabel1.Text = name;
                        toolTip1.SetToolTip(linkLabel1, name);
                    })
                    );

                }

                FileInfo info = new FileInfo("CachePic\\" + p.url.Substring(p.url.LastIndexOf("/") + 1, 8) + ".jpg");
                if (!p.refresh && info.Exists && info.Length > 0)
                {
                    Utils.decrypt(info, "RJ");
                    StreamReader rd = info.OpenText();

                    if (this.now_url != p.url)
                    {
                        rd.Close();
                        Utils.encrypt(info, "RJ");
                        Thread.CurrentThread.Abort();
                        return;
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromStream(rd.BaseStream);
                    }
                    rd.Close();
                    Utils.encrypt(info, "RJ");
                    return;
                }

                //WebClient a = new WebClient();
                //info.OpenText().Close();
                byte[] buffer = a.DownloadData(p.url);

                //pictureBox1.Image = Image.FromFile("CachePic\\" + now_url.ToString().Substring(now_url.ToString().LastIndexOf("/") + 1, 8));

                if (!info.Exists)
                {
                    info.Create().Close();
                }
                else
                {
                    Utils.decrypt(info, "RJ");
                }

                FileStream x = info.OpenWrite();
                x.Write(buffer, 0, buffer.Length);
                x.Close();
                Utils.encrypt(info, "RJ");


                if (this.now_url != p.url)
                {
                    Thread.CurrentThread.Abort();
                }
                MemoryStream m = new MemoryStream(buffer);
                pictureBox1.Image = Image.FromStream(m);
                m.Close();

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Exception");
            }


        }

        public static string fileSize(long length)
        {
            long m = length;
            int level = 0;
            double a = (double)m;
            String[] unit = { "B", "KB", "MB", "GB", "TB" };
            while (m / 1024 > 0)
            {
                m /= 1024;
                level++;
                a /= 1024.0;
            }
            return a.ToString("0.##") + unit[level];
        }

        public void RefreshFiles()
        {
            String pattern = @"[rR][jJ][0-9]{6}";
            String pattern2 = @"(?<!\d)(\d{6}(?!\d))";
            listBox1.Items.Clear();
            //rjf.Clear();
            int i = 0;
            foreach (String folder in FolderManager.loadList())
            {
                DirectoryInfo info = new DirectoryInfo(folder);
                if (info.Exists)
                {
                    listBox1.Items.Add(new ListInfo("-----------------------------", -1, null));
                    listBox1.Items.Add(new ListInfo(folder, -2, null));
                    listBox1.Items.Add(new ListInfo("-----------------------------", -1, null));
                    RJFile c;

                    foreach (FileInfo f in info.GetFiles())
                    {
                        c.fullPath = f.FullName;
                        c.RJ = "";
                        foreach (Match match in Regex.Matches(f.Name, pattern))
                        {
                            if (c.RJ.Length > 0)
                            {
                                c.RJ = c.RJ + ',';
                            }
                            c.RJ = c.RJ + match.ToString().ToUpper();
                        }
                        c.fuzzy = false;
                        if (c.RJ == "" && Regex.Matches(f.Name, pattern2).Count >= 1)
                        {
                            foreach (Match match in Regex.Matches(f.Name, pattern2))
                            {
                                if (c.RJ.Length > 0)
                                {
                                    c.RJ = c.RJ + ',';
                                }
                                c.RJ = c.RJ + "RJ" + match.ToString();
                            }
                            c.fuzzy = true;
                        }
                        else if (c.RJ == "")
                        {
                            c.RJ = "?";
                            c.fuzzy = null;
                        }
                        //rjf.Add(i++, c);
                        ListInfo info1 = new ListInfo(f.Name, i, c);
                        listBox1.Items.Add(info1);
                    }
                }
            }

            if (co != null) co.Clear();

            foreach (Object o in listBox1.Items)
            {
                co.Add(o);
            }

            filter();

        }

        private void Open_Click(object sender, EventArgs e)
        {
            FileInfo i = new FileInfo((listBox1.SelectedItem as ListInfo).File.fullPath);
            if (!i.Exists)
            {
                MessageBox.Show("错误", "文件不存在，可能已被移动或删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = (listBox1.SelectedItem as ListInfo).File.fullPath;
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = info;
            p.Start();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            info.Arguments = "/select," + (listBox1.SelectedItem as ListInfo).File.fullPath;
            Process p = new Process();
            p.StartInfo = info;
            p.Start();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfo(comboBox1.SelectedItem.ToString(), false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Logging.Text = picDownloader == null ? "Null" : picDownloader.ThreadState.ToString();
            /*if (comboBox1.SelectedItem != null && pictureBox1.Image != null && pictureBox1.Image != Resources.Resource1.Wait && picDownloader!=null && picDownloader.ThreadState.Equals(System.Threading.ThreadState.Stopped))
            {
                this.loaded_rj = comboBox1.SelectedItem.ToString();
                FileInfo info = new FileInfo("CachePic\\" + now_url.Substring(now_url.LastIndexOf("/") + 1, 8));
                StreamReader rdr = info.OpenText();
                Image img = Image.FromStream(rdr.BaseStream);
                rdr.Close();
                pictureBox1.Image = img;
                //img.Dispose();
            }*/
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {


        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    System.Diagnostics.Process.Start("https://www.dlsite.com/maniax/work/=/product_id/" + comboBox1.SelectedItem + ".html");
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Modify((listBox1.SelectedItem as ListInfo).File.RJ).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = (sender as ListBox).IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                String text = listBox1.Items[index].ToString(); //+ "\n" + ((ListInfo)listBox1.Items[index]).getNum().ToString();
                if (toolTip1.Active && toolTip1.GetToolTip((ListBox)sender) == text)
                {
                    //toolTip1.Show(text, sender as ListBox, e.Location.X + 15, e.Location.Y);
                }
                else
                {
                    toolTip1.Show(text, sender as ListBox, e.Location.X + 15, e.Location.Y);
                }
            }
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            if (toolTip1.Active)
            {
                toolTip1.Hide(this);
            }
        }


        private void fb2_Click(object sender, EventArgs e)
        {
            fb2.BackColor = fb2.BackColor == Color.DarkGray ? Color.Transparent : Color.DarkGray;
            Aregex r;
            //r.regex = @"[R|r][J|j][0-9]{6}";
            r = (info) =>
            {
                return info.File.fuzzy == null && info.getNum() >= 0;
            };

            if (fb2.BackColor != Color.Transparent)
            {
                regexes.Add(r);
            }
            else
            {
                regexes.Remove(r);
            }
            filter();
        }

        private void fb1_Click(object sender, EventArgs e)
        {
            fb1.BackColor = fb1.BackColor == Color.DarkGray ? Color.Transparent : Color.DarkGray;
            Aregex r;
            //r.regex = @"[R|r][J|j][0-9]{6}";
            r = (info) =>
            {
                return info.File.fuzzy == false;
            };
            if (fb1.BackColor != Color.Transparent)
            {
                regexes.Add(r);
            }
            else
            {
                regexes.Remove(r);
            }
            filter();
        }



        private delegate bool Aregex(ListInfo o);
        private List<Aregex> regexes = new List<Aregex>();
        /*private struct Aregex
        {
            public String regex;
            public MatchTime matchTime;
        } */

        private void filter()
        {
            bool flag = false;
            List<Object> deleteList = new List<Object>();
            //rjf.Clear();
            foreach (Object o in co)
            {
                if ((o.ToString()) == "-----------------------------")
                {
                    flag = !flag;
                }
                else if (!flag)
                {
                    foreach (Aregex a in regexes)
                    {
                        if (a(o as ListInfo))
                        {
                            deleteList.Add(o);
                            break;
                        }
                    }

                }
            }

            listBox1.Items.Clear();
            //TODO:把RJFile重构到ListInfo类里，之后就不需要字典了
            //TODO:顺便更新一下博客教大家如何在ListInfo里放Object
            foreach (Object o in co)
            {
                if (!deleteList.Contains(o))
                {
                    listBox1.Items.Add(o);
                }

            }
        }

        private void fc1_CheckedChanged(object sender, EventArgs e)
        {
            Aregex r;
            //r.regex = @"(?<!\d)(\d{6}(?!\d))";
            r = (info) =>
            {
                return info.File.fuzzy == true;
            };
            if (!fc1.Checked)
            {
                regexes.Add(r);
            }
            else
            {
                regexes.Remove(r);
            }
            filter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (new DirectoryInfo(workDirectory).Exists == false)
            {
                MessageBox.Show("未指定有效的工作文件夹\n（" + workDirectory + "）");
                return;
            }
            if (MessageBox.Show(this, "确认移动？移动后不可撤销！", "确认？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                button5.Enabled = false;
                FileInfo f = new FileInfo((listBox1.SelectedItem as ListInfo).File.fullPath);
                if (f.Exists)
                {
                    FileInfo info = new FileInfo(workDirectory + "\\" + f.Name);
                    if (info.Exists)
                    {
                        MessageBox.Show("发现文件重名，请自行解决冲突");
                        button5.Enabled = true;
                        return;
                    }
                    //info.Create();
                    f.MoveTo(workDirectory + "\\" + f.Name);
                    MessageBox.Show(this, "已将文件移至工作区", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Middle) && (comboBox1.SelectedItem != null))
            {
                loadInfo(comboBox1.SelectedItem.ToString(), false, true);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainW_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Aregex r;
            //r.regex = @"(?<!\d)(\d{6}(?!\d))";
            r = (info) =>
            {
                FileInfo i = new FileInfo(info.File.fullPath);
                return !((i.CreationTime.Date.CompareTo(dateTimePicker1.Value.Date) >= 0) && (i.CreationTime.Date.CompareTo(dateTimePicker2.Value.Date) <= 0));
            };
            if ((sender as CheckBox).Checked)
            {
                regexes.Add(r);
            }
            else
            {
                regexes.Remove(r);
            }
            filter();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as DateTimePicker).Value.Date.CompareTo(dateTimePicker2.Value.Date) > 0)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
                return;
            }
            if (checkBox1.Checked)
            {
                filter();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as DateTimePicker).Value.Date.CompareTo(dateTimePicker1.Value.Date) < 0)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
                return;
            }
            if (checkBox1.Checked)
            {
                filter();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aregex r;
            //r.regex = @"(?<!\d)(\d{6}(?!\d))";
            r = (info) =>
            {
                return !info.ToString().Contains(textBox1.Text);
            };
            if (!regexes.Contains(r))
            {
                regexes.Add(r);
            }
            filter();
        }
    }
}
