using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    public class InfoSection : BaseInfoType
    {
        List<BaseInfoType> infoList = new List<BaseInfoType>();

        string title;
        public string Title { get { return title; } }

        public InfoSection(string title)
        {
            this.title = title;
        }

        public void AddInfo(BaseInfoType info, int pos = -1)
        {
            if(pos >= 0)
            {
                infoList.Insert(pos, info);
            }
            else
            {
                infoList.Add(info);
            }
        }

        public List<BaseInfoType>.Enumerator GetEnumerator()
        {
            return infoList.GetEnumerator();
        }

        public override InfoType GetInfoType()
        {
            return InfoType.InfoSection;
        }
    }
}
