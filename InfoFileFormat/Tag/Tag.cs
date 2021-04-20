using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class Tag
    {
        public String Content
        {
            get;
            set;
        }

        public Tag(String content)
        {
            this.Content = content;
        }

        public override string ToString()
        {
            return "<Tag>"+Content;
        }

        public static Collection<InfoFile> Filter(SortedSet<Tag> tags, Collection<InfoFile> infos, String collectionName)
        {
            Collection<InfoFile> a = new Collection<InfoFile>();
            foreach(InfoFile f in infos)
            {
                if(f.Info.ContainsKey(collectionName) && f.Info[collectionName].GetInfoType() == BaseInfoType.InfoType.Tag)
                {
                    if((f.Info[collectionName] as TagCollection).HasTags(tags))
                    {
                        a.Add(f);
                    }
                }
            }
            return a;
        }
    }
}
