using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser.Util;

namespace RJ_Manager.HTMLProcesser
{
    public class HTMLParser
    {
        public String rawHTML;
        public Lexer lexer;
        public Parser parser;


        protected HTMLParser() { }
        
        
        public NodeList GetNodes(String attribute, String regex)
        {
            AttributeRegexFilter filter = new AttributeRegexFilter(attribute, regex, true);
            NodeList nodeList = this.parser.Parse(filter);

            return nodeList;
        }

        public INode GetFirstNode(String attribute, String regex)
        {
            NodeList list = GetNodes(attribute, regex);

            return list.ElementAt(0);
        }

        public static HTMLParser GetByHTML(String page)
        {
            Lexer lexer = new Lexer(page);
            Parser parser = new Parser(lexer);

            HTMLParser htmlParser = new HTMLParser();
            htmlParser.rawHTML = page;
            htmlParser.lexer = lexer;
            htmlParser.parser = parser;

            return htmlParser;
        }
    }
}
