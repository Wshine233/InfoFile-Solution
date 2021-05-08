using InfoFileFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ_Manager.InfoFormat
{
    public class RJInfo : InfoTemplate
    {
        public RJInfo()
        {
            this.TemplateList.Add("RJ Number", BaseInfoType.InfoType.LiteralText);
            this.TemplateList.Add("RJ Number", BaseInfoType.InfoType.LiteralText);
        }
    }
}
