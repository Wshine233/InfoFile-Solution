using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class LiteralText : BaseInfoType
    {
        private Encoding charset;
        

        public LiteralText(String name, String data, Encoding charset)
        {
            this.name = name;
            SetData(data, charset);
            this.charset = charset;

            //UpdateTime();
        }

        public LiteralText(String name, String data)
        {
            this.name = name;
            this.charset = Encoding.UTF8;
            SetData(data);
            

            //UpdateTime();
        }

        public void SetData(String x, Encoding charset)
        {
            SetData(charset.GetBytes(x));
            this.charset = charset;

            UpdateTime();
        }

        public void SetData(String x)
        {
            SetData(x, this.charset);

            UpdateTime();
        }

        public override string ToString()
        {
            return charset.GetString(this.Data);

        }

        public override InfoType GetInfoType()
        {
            return InfoType.LiteralText;
        }

    }
}
