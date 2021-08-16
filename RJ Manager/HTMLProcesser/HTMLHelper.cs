using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Nodes;
using Winista.Text.HtmlParser.Util;

namespace RJ_Manager.HTMLProcesser
{
    public static class HTMLHelper
    {
        readonly static String[] specialChar = { "&", "\"", "<", ">","^","~", "♥", "♦", "♠", "♣", "™" , "⌈", "⌉",
            "⌊", "⌋","⟨","⟩","◊","•"," ","∀","∂",
            "∃","∅","∇","∏","∑","∗","√","∝",
            "∞","∠","∧","∨","∩","∪","∫","∴","∼",
            "≅","≈","≠","≡","≤","≥","⊕","⊗","⊥",
            "⋅","℘","ℑ","ℜ","ℵ","Α","Β","Γ","Δ",
            "Ε","Ζ","Η","Θ","Ι","Λ","Ξ","Ο","Π",
            "Σ","Υ","Φ","Χ","Ψ","Ω","α","β","γ",
            "δ","ε","ζ","η","θ","ι","λ","μ","ν",
            "ξ","ο","π","ρ","ς","σ","τ","φ","χ",
            "ψ","ω","ϑ","ϒ","ϖ","–","—","‘","’",
            "‚","“","”","„","‰","‹","›","€","¢",
            "¡","£","¤","¥","¦","§","©","ª","«",
            "¬"," ","®","°","±","²","³","´","µ",
            "¶","·","¹","º","»","¼","½","¾","¿",
            "Ø","÷","þ","←","↑","→","↓","↔","↵",
            "⇐","⇑","⇒","⇓","⇔","","","","",
            "","","","","","","","","",};
        readonly static String[] specialTag = { "&amp;", "&quot;", "&lt;", "&gt;","&circ;","&tilde;", "&hearts;", "&diams;", "&spades;", "&clubs;", "&trade;" , "&lceil;", "&rceil;",
            "&lfloor;", "&rfloor;","&lang;","&rang;","&loz;","&bull;","&nbsp;","&forall;","&part;",
            "&exist;","&empty;","&nabla;","&prod;","&sum;","&lowast;","&radic;","&prop;",
            "&infin;","&ang;","&and;","&or;","&cap;","&cup;","&int;","&there4;","&sim;",
            "&cong;","&asymp;","&ne;","&equiv;","&le;","&ge;","&oplus;","&otimes;","&perp;",
            "&sdot;","&weierp;","&image;","&real;","&alefsym;","&Alpha;","&Beta;","&Gamma;","&Delta;",
            "&Epsilon;","&Zeta;","&Eta;","&Theta;","&Iota;","&Lambda;","&Xi;","&Omicron;","&Pi;",
            "&Sigma;","&Upsilon;","&Phi;","&Chi;","&Psi;","&Omega;","&alpha;","&beta;","&gamma;",
            "&delta;","&epsilon;","&zeta;","&eta;","&theta;","&iota;","&lambda;","&mu;","&nu;",
            "&xi;","&omicron;","&pi;","&rho;","&sigmaf;","&sigma;","&tau;","&phi;","&chi;",
            "&psi;","&omega;","&thetasym;","&upsih;","&piv;","&ndash;","&mdash;","&lsquo;","&rsquo;",
            "&sbquo;","&ldquo;","&rdquo;","&bdquo;","&permil;","&lsaquo;","&rsaquo;","&euro;","&cent;",
            "&iexcl;","&pound;","&curren;","&yen;","&brvbar;","&sect;","&copy;","&ordf;","&laquo;",
            "&not;","&shy;","&reg;","&deg;","&plusmn;","&sup2;","&sup3;","&acute;","&micro;",
            "&para;","&middot;","&sup1;","&ordm;","&raquo;","&frac14;","&frac12;","&frac34;","&iquest;",
            "&Oslash;","&divide;","&thorn;","&larr;","&uarr;","&rarr;","&darr;","&harr;","&crarr;",
            "&lArr;","&uArr;","&rArr;","&dArr;","&hArr;","","","","",
            "","","","","","","","","",};


        public readonly static WebClient client = new WebClient();


        public static string ReplaceSpecialCharacters(string s)
        {
            for (int i = 0; i < specialTag.Length; i++)
            {
                if (specialTag[i] != "")
                {
                    s = s.Replace(specialTag[i], specialChar[i]);
                }
            }

            return s;
        }

        public static void RemoveMeaninglessNodes(this NodeList list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                INode node = list.ElementAt(i);

                if(node is TextNode && node.ToPlainTextStringEx().Trim().Equals(""))
                {
                    list.Remove(node);
                }
            }
        }

        public static String TrimAll(this String s)
        {
            String after = "";
            s = s.Replace("\n", " ");
            s = s.Replace("\t", " ");

            bool space = false;
            foreach(char c in s)
            {
                if(c == ' ')
                {
                    if (!space)
                    {
                        after += " ";
                        space = true;
                    }
                }
                else
                {
                    after += c;
                    space = false;
                }
            }

            return after;
        }

        public static String GetRJHTMLString(String rj, bool refresh = false)
        {
            FileInfo inf = new FileInfo("CachePic\\" + rj + ".html");
            String docs;
            if (inf.Exists && !refresh)
            {
                Utils.Decrypt(inf, "RJ");
                StreamReader r = inf.OpenText();
                docs = r.ReadToEnd();
                r.Close();
                Utils.Encrypt(inf, "RJ");
            }
            else
            {
                docs = GetHTMLString("https://www.dlsite.com/maniax/work/=/product_id/" + rj + ".html");
                inf.Open(FileMode.Create).Close();
                StreamWriter wr = inf.CreateText();
                wr.Write(docs);
                wr.Close();
                Utils.Encrypt(inf, "RJ");
            }

            return docs;
        }

        public static String GetHTMLString(String url)
        {
            String docs;

            byte[] document = client.DownloadData(url);
            docs = Encoding.UTF8.GetString(document);

            return docs;
        }

        public static Image GetRJImage(String rj, bool refresh = false)
        {
            if (rj == "?") return Resources.Resource1.Wait;

            Image im;

            FileInfo info = new FileInfo("CachePic\\" + rj + ".jpg");
            if (!refresh && info.Exists && info.Length > 0)
            {
                Utils.Decrypt(info, "RJ");
                StreamReader rd = info.OpenText();
                im = Image.FromStream(rd.BaseStream);
                rd.Close();
                Utils.Encrypt(info, "RJ");
            }
            else
            {
                im = GetWebImage("https://img.dlsite.jp/modpub/images2/work/doujin/RJ" + (int.Parse(rj.Substring(2, 3)) + 1).ToString("000") + "000/" + rj + "_img_main.jpg");

                info.Delete();
                info.Create().Close();
                Bitmap bitmap = new Bitmap(im);
                bitmap.Save(info.FullName);
                Utils.Encrypt(info, "RJ");
            }

            return im;
        }

        public static Image GetWebImage(String url)
        {
            Image im;
            byte[] buffer = client.DownloadData(url);

            MemoryStream m = new MemoryStream(buffer);
            im = Image.FromStream(m);
            m.Close();

            return im;
        }
    }
}
