using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class TagCollection : BaseInfoType
    {


        public override InfoType GetInfoType()
        {
            return InfoType.Tag;
        }
    }
}
