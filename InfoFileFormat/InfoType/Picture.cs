using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    class Picture : BaseInfoType
    {
        public Picture(String name, byte[] data)
        {
            this.name = name;
            setData(data);

            updateTime();
        }

    }
}
