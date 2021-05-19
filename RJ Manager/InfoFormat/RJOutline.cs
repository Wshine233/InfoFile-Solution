using InfoFileFormat;
using RJ_Manager.HTMLProcesser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Util;

namespace RJ_Manager.InfoFormat
{
    public class RJOutline
    {
        Dictionary <String, String> data = new Dictionary<string, string>();

        public String ReleaseDate
        {
            get
            {
                return FindInfo(3);
            }
        }
        public String Age
        {
            get
            {
                return FindInfo(4);
            }
        }
        public String ProductFormat
        {
            get
            {
                return FindInfo(5);
            }
        }
        public String FileFormat
        {
            get
            {
                return FindInfo(6);
            }
        }
        public String Genre
        {
            get
            {
                return FindInfo(7);
            }
        }
        public String FileSize
        {
            get
            {
                return FindInfo(8);
            }
        }

        public String SeriesName
        {
            get
            {
                return FindInfo(9);
            }
        }
        public String LastUpdated
        {
            get
            {
                return FindInfo(10);
            }
        }
        public String Author
        {
            get
            {
                return FindInfo(11);
            }
        }
        public String Scenario
        {
            get
            {
                return FindInfo(12);
            }
        }
        public String Illustration
        {
            get
            {
                return FindInfo(13);
            }
        }
        public String VoiceActor
        {
            get
            {
                return FindInfo(14);
            }
        }
        public String SupportedLanguages
        {
            get
            {
                return FindInfo(15);
            }
        }


        public RJOutline(String docs)
        {
            HTMLParser p = HTMLParser.GetByHTML(docs);

            NodeList nodes = p.GetFirstNode("id", "work_outline").Children;
            nodes.KeepAllNodesThatMatch(new TagNameFilter("tr"));

            for (int i = 0; i < nodes.Count; i++)
            {
                INode node = nodes.ElementAt(i);

                if (node != null)
                {
                    node.Children.RemoveMeaninglessNodes();
                    this.data.Add(node.FirstChild.ToPlainTextStringEx().Trim(), node.LastChild.ToDividedTextString(" ").TrimAll());
                }
            }
        }


        public InfoGroup<BaseInfoType> ToInfoGroup()
        {
            InfoGroup<BaseInfoType> g = new InfoGroup<BaseInfoType>("RJOutline");

            foreach(KeyValuePair<String, String> kv in this.data)
            {
                TagCollection tc = new TagCollection(kv.Key);

                if (LocaleTexts.IsEqual("分类", kv.Key))
                {
                    String[] s = kv.Value.Split(' ');
                    foreach(String ss in s)
                    {
                        tc.AddTag(new Tag(ss));
                    }
                }
                else if(LocaleTexts.IsEqual("作者", kv.Key) ||
                     LocaleTexts.IsEqual("剧情", kv.Key) ||
                     LocaleTexts.IsEqual("插画", kv.Key) ||
                     LocaleTexts.IsEqual("声优", kv.Key))
                {
                    String[] s = kv.Value.Split(new String[] { " / " }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (String ss in s)
                    {
                        tc.AddTag(new Tag(ss));
                    }
                }
                else
                {
                    tc.AddTag(new Tag(kv.Value));
                }

                g.InfoList.Add(tc.Name, tc);
            }

            return g;
        }

        private String FindInfo(int localeTextIndex)
        {

            String[] locale = new String[5];
            for(int i = 0; i < 5; i++)
            {
                locale[i] = LocaleTexts.texts[localeTextIndex, i];
            }


            foreach (KeyValuePair<String, String> kv in this.data)
            {
                foreach(String s in locale)
                {
                    if (s.Equals(kv.Key))
                    {
                        return kv.Value;
                    }
                }
            }

            return null;
        }
    }
}
