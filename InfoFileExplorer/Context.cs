using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using InfoFileFormat;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace InfoFileViewer
{
    public class Context
    {
        public string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                info.Name = value;
            }
        }

        public string content;
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                if (info.GetType().Equals(BaseInfoType.InfoType.LiteralText))
                {
                    (this.info as LiteralText).SetData(value);
                }
                
            }
        }
        public ImageSource Source
        {
            get;
            set;
        }

        public BaseInfoType info;
        MemoryStream ms;

        public Context(BaseInfoType con)
        {
            this.info = con;
            this.Name = this.info.Name;
            this.Content = this.info.ToString();
            if (con.GetInfoType().Equals(BaseInfoType.InfoType.Picture))
            {
                ms = new MemoryStream(con.Data);

                ImageBrush imageBrush = new ImageBrush();
                ImageSourceConverter imageSourceConverter = new ImageSourceConverter();

                this.Source = (ImageSource)imageSourceConverter.ConvertFrom(ms);
                //ms.Close();
            }
            
        }

        public void Refresh()
        {
            if(ms != null)
            {
                ms.Close();
            }
            
            this.Name = this.info.Name;
            this.Content = this.info.ToString();
            if (info.GetInfoType().Equals(BaseInfoType.InfoType.Picture))
            {
                ms = new MemoryStream(info.Data);

                ImageBrush imageBrush = new ImageBrush();
                ImageSourceConverter imageSourceConverter = new ImageSourceConverter();

                this.Source = (ImageSource)imageSourceConverter.ConvertFrom(ms);
                //ms.Close();
            }
        }

        
    }
}
