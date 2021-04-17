using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InfoFileFormat
{
    public class Tag
    {
        String Content
        {
            get;
            set;
        }

        public Tag(String content)
        {
            this.Content = content;
        }

        public static Collection<InfoFile> Filter(Collection<Tag> tags, Collection<InfoFile> infos, String collectionName)
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
