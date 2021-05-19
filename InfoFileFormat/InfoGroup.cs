using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    [Serializable]
    public class InfoGroup<E> : BaseInfoType
    {
        public Dictionary<String, E> InfoList
        {
            get;
            set;

        } = new Dictionary<String, E>();


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


        public E[] ToInfoArray()
        {
            E[] array = new E[Count()];

            foreach(KeyValuePair<String, E> info in InfoList)
            {
                array.Append(info.Value);
            }

            return array;
        }


        public override InfoType GetInfoType()
        {
            return InfoType.InfoGroup;
        }

    }
}
