using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winista.Text.HtmlParser;

namespace RJ_Manager.HTMLProcesser
{
    public static class NodeEx
    {
        public static String ToPlainTextStringEx(this INode node)
        {
            String s = node.ToPlainTextString();
            s = HTMLHelper.ReplaceSpecialCharacters(s);

            return s;
        }

        public static String ToDividedTextString(this INode node, String dividingString)
        {
            String after = "";
            List<INode> list = new List<INode>();

            list.Add(node);
            while(list.Count > 0)
            {
                INode n = list[0];
                list.RemoveAt(0);

                if(n.Children == null)
                {
                    if (n.ToPlainTextStringEx().Trim() != "")
                    {
                        after += n.ToPlainTextStringEx().Trim() + dividingString;
                    }
                }
                else
                {
                    for(int i = n.Children.Count - 1; i >= 0; i--)
                    {
                        list.Insert(0, n.Children.ElementAt(i));
                    }
                }
            }

            return after.Remove(after.Length - dividingString.Length);
        }
    }
}
