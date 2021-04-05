using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    class LiteralText : BaseInfoType
    {
        private Encoding charset;
        public LiteralText(String name, String data, Encoding charset)
        {
            this.name = name;
            setData(data, charset);
            this.charset = charset;

            updateTime();
        }

        public LiteralText(String name, String data)
        {
            this.name = name;
            setData(data);

            updateTime();
        }

        public void setData(String x, Encoding charset)
        {
            setData(charset.GetBytes(x));

            updateTime();
        }

        public void setData(String x)
        {
            setData(x, Encoding.UTF8);

            updateTime();
        }

        public override string ToString()
        {
            return charset.GetString(this.Data);

        }

    }
}
