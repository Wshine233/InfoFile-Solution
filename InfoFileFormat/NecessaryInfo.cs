using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    [Serializable]
    public class NecessaryInfo : BaseInfoType
    {
        public Dictionary<String, String> Info { get; } = new Dictionary<String, String>();
        public NecessaryInfo(String version, String path, String size, String md5)
        {
            this.name = "NecessaryInfo";
            Info.Add("Version", version);
            Info.Add("Path", path);
            Info.Add("Size", size);
            Info.Add("MD5", md5);

        }

        public override InfoType GetInfoType()
        {
            return InfoType.NecessaryInfo;
        }
    }
}
