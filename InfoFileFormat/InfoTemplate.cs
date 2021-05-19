using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    public class InfoTemplate
    {
        String name;
        public String Name
        {
            get
            {
                return name;
            }
        }

        public Dictionary<String, BaseInfoType.InfoType> TemplateList
        {
            get;
            set;

        } = new Dictionary<String, BaseInfoType.InfoType>();

        public Dictionary<String, BaseInfoType.InfoType> OptionalList
        {
            get;
            set;

        } = new Dictionary<String, BaseInfoType.InfoType>();


        public InfoTemplate(String name)
        {
            this.name = name;
        }


        public bool Check(InfoFile file, bool isOnly)
        {
            if (isOnly && file.Info.Count != TemplateList.Count)
            {
                return false;
            }
            
            foreach (KeyValuePair<string, BaseInfoType.InfoType> tmpl in TemplateList)
            {
                if(!file.Info.ContainsKey(tmpl.Key) || !tmpl.Value.Equals(file.Info[tmpl.Key].GetInfoType()))
                {
                    return false;
                }
            }
            
            return true;
        }


        public int Count()
        {
            return TemplateList.Count + OptionalList.Count;
        }


        public int GetIndex(String name)
        {
            int i = 0;
            foreach(String n in TemplateList.Keys)
            {
                if (n.Equals(name))
                {
                    return i;
                }
                i++;
            }

            foreach (String n in OptionalList.Keys)
            {
                if (n.Equals(name))
                {
                    return i;
                }
                i++;
            }

            return -1;
        }


        public InfoGroup<BaseInfoType> GetByTemplate(InfoFile file)
        {
            if(!Check(file, false))
            {
                return null;
            }
            KeyValuePair<String, BaseInfoType>[] listArray = new KeyValuePair<string, BaseInfoType>[Count()];
            foreach(KeyValuePair<String, BaseInfoType> info in file.Info)
            {
                int index = GetIndex(info.Key);
                if (index != -1)
                {
                    listArray[index] = info;
                    continue;
                }
            }

            InfoGroup<BaseInfoType> group = new InfoGroup<BaseInfoType>(this.Name);
            foreach(KeyValuePair<String, BaseInfoType> info in listArray)
            {
                group.InfoList.Add(info.Key, info.Value);
            }

            return group;
        }
    }
}
