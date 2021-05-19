using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class TagCollection : BaseInfoType
    {
        SortedSet<Tag> tags = new SortedSet<Tag>(new TagComparer());

        public TagCollection(String name)
        {
            this.name = name;
        }

        public void AddTag(Tag tag)
        {
            tags.Add(tag);
        }

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

        public override string ToString()
        {
            string a = name;
            Tag[] tagArray = new Tag[tags.Count];
            tags.CopyTo(tagArray);
            for (int i = 0; i < tagArray.Length; i++)
            {
                if (i > 0)
                {
                    a += " ";
                }
                a += tagArray[i];
                
            }
            return a;
        }

        public String[] ToPlainTexts()
        {
            String[] a = new String[tags.Count];
            Tag[] tagArray = new Tag[tags.Count];
            tags.CopyTo(tagArray);
            for (int i = 0; i < tagArray.Length; i++)
            {
                a[i] = tagArray[i].Content;
            }

            return a;
        }
    }

    [Serializable]
    class TagComparer : Comparer<Tag>
    {
        public override int Compare(Tag x, Tag y)
        {
            return x.Content.CompareTo(y.Content);
        }
    }
}
