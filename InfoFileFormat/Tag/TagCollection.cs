using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class TagCollection : BaseInfoType
    {
        SortedSet<Tag> tags = new SortedSet<Tag>();

        public bool HasTag(Tag tag)
        {
            return tags.Contains(tag);
        }

        public bool HasTags(SortedSet<Tag> tags)
        {
            foreach(Tag t in tags)
            {
                if (!this.tags.Contains(t))
                {
                    return false;
                }
            }

            return true;
        }

        public SortedSet<Tag> GetIntersection(SortedSet<Tag> tags)
        {
            SortedSet<Tag> a = new SortedSet<Tag>();
            foreach(Tag t in this.tags)
            {
                a.Add(t);
            }
            a.IntersectWith(tags);
            return a;
        }

        public SortedSet<Tag> GetUnion(SortedSet<Tag> tags)
        {
            SortedSet<Tag> a = new SortedSet<Tag>();
            foreach (Tag t in this.tags)
            {
                a.Add(t);
            }
            a.UnionWith(tags);
            return a;
        }

        public SortedSet<Tag> Copy()
        {
            SortedSet<Tag> a = new SortedSet<Tag>();
            foreach (Tag t in this.tags)
            {
                a.Add(t);
            }
            return a;
        }

        public override InfoType GetInfoType()
        {
            return InfoType.Tag;
        }
    }
}
