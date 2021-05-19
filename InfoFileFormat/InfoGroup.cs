using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    [Serializable]
    public class InfoGroup : BaseInfoType
    {
        public Dictionary<String, BaseInfoType> InfoList
        {
            get;
            set;

        } = new Dictionary<String, BaseInfoType>();


        public InfoGroup(String name) 
        {
            this.Name = name;
        }


        public int Count()
        {
            return InfoList.Count;
        }


        public int GetIndex(String name)
        {
            int i = 0;
            foreach(String n in InfoList.Keys)
            {
                if (n.Equals(name))
                {
                    return i;
                }
                i++;
            }

            return -1;
        }


        public override InfoType GetInfoType()
        {
            return InfoType.InfoGroup;
        }

    }
}
