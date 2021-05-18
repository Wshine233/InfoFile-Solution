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
    }
}
