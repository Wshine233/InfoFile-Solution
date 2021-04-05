using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class Picture : BaseInfoType
    {
        //ImageFormat format;

        public Picture(String name, byte[] data, ImageFormat format)
        {
            this.name = name;
            SetData(data);

            //this.format = format;

            //UpdateTime();
        }

        public Picture(String name, FileInfo info)
        {
            this.name = name;
            Image image = Image.FromFile(info.FullName);
            FileStream reader = info.OpenRead();
            byte[] data = new byte[info.Length];
            reader.Read(data, 0, data.Length);
            reader.Close();

            SetData(data);

            //this.format = image.RawFormat.;

            //UpdateTime();
        }

        public Picture(String name, Image image)
        {
            this.name = name;
            MemoryStream memStream = new MemoryStream();
            image.Save(memStream,image.RawFormat);
            SetData(memStream.ToArray());
            memStream.Close();

            //this.format = image.RawFormat;

            //UpdateTime();
        }

        public Image ToImage()
        {
            MemoryStream m = new MemoryStream(this.Data);
            Image i = Image.FromStream(m);
            m.Close();
            return i;
            
        }

        public void SetData(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            base.SetData(ms.ToArray());
            ms.Close();
        }

        public override InfoType GetInfoType()
        {
            return InfoType.Picture;
        }
    }
}
