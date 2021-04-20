using InfoFileFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager
{
    public partial class TopWindow : Form
    {
        public TopWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainW mainWindow = new MainW();
            mainWindow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo("testinfo");
            FileStream writer = info.Create();
            byte[] buffer = InfoFile.TEST_VALUE.Serialize();
            writer.Write(buffer,0,buffer.Length);
            writer.Close();

            InfoFile infoFile2 = InfoFile.Parse(info.FullName);
            MessageBox.Show("My First Test Text\n" + (infoFile2.HasInfo("My First Test Text") ? infoFile2.GetInfo("My First Test Text").ToString() : "Null"));
            dynamic pic = infoFile2.GetInfo("FirstPic");
            pictureBox1.Image = pic.ToImage();
            MessageBox.Show(infoFile2.GetInfo("My First Test Text").Metadata[BaseInfoType.UPDATE_TIME].ToString());
            MessageBox.Show(infoFile2.GetInfo("Test Collection").ToString());



        }
    }
}
