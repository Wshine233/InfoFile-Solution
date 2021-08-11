using InfoFileFormat;
using RJ_Manager.HTMLProcesser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winista.Text.HtmlParser;

namespace RJ_Manager.InfoFormat
{
    public enum Locale
    {
        ja_JP = 0,
        en_US = 1,
        zh_CN = 2,
        zh_TW = 3,
        ko_KR = 4
    }


    public class LocaleTexts
    {
        public readonly static String[,] texts = {
            {"名前", "WorkName", "作品名", "作品名", "이름"},
            {"サークル名", "Circle", "社团名", "社團名", "서클명"},
            {"画像", "Image", "封面图", "封面圖", "영상"},
            {"販売日", "Release date", "贩卖日","販賣日",  "판매일"},
            {"年齢指定", "Age", "年龄指定", "年齡指定", "연령 지정"},
            {"作品形式", "Product format", "作品类型", "作品形式", "작품 형식"},
            {"ファイル形式", "File format", "文件形式", "檔案形式", "파일 형식"},
            {"ジャンル", "Genre", "分类", "分類", "장르"},
            {"ファイル容量", "File size", "文件容量", "檔案容量", "파일 용량"},

            {"シリーズ名", "Series name", "系列名", "系列名", "시리즈명"},
            {"最終更新日", "Last updated", "最终更新日", "最終更新日", "최종 갱신일"},
            {"作者", "Author", "作者", "作者", "저자"},
            {"シナリオ", "Scenario", "剧情", "劇本", "시나리오"},
            {"イラスト", "Illustration", "插画", "插畫", "일러스트"},
            {"声優", "Voice Actor", "声优", "聲優", "성우"},
            {"対応言語", "Supported languages", "对应语言", "對應語言", "대응 언어"},
            {"作品内容", "Product summary", "作品内容", "作品內容", "작품 내용"},
            {"評価", "Rating", "评价", "評價", "평가"}
        };

        public static bool IsEqual(String a, String b)
        {
            int posA = -1;
            int posB = -2;

            for(int i = 0; i < 18; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (texts[i, j].Equals(a))
                    {
                        posA = i;
                    }

                    if (texts[i, j].Equals(b))
                    {
                        posB = i;
                    }
                }
            }

            return posA == posB;
        }

        public static Locale? GetLanguage(String s)
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (texts[i, j].Equals(s))
                    {
                        switch (i)
                        {
                            case 0:
                                return Locale.ja_JP;
                            case 1:
                                return Locale.en_US;
                            case 2:
                                return Locale.zh_CN;
                            case 3:
                                return Locale.zh_TW;
                            case 4:
                                return Locale.ko_KR;
                        }
                    }
                }
            }

            return null;
        }

        public static String InLang(String s, Locale locale)
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(texts[i,j] == s)
                    {
                        return texts[i, (int)locale];
                    }
                }
            }

            throw new Exception("无法找到该文字的语言");
        }
    }

    
    public class RJInfo
    {
        /*共有项：
            作品名
            ——————社团名
            ——————预览图（组）
            贩卖日
            年龄指定
            作品类型
            文件形式
            分类
            文件容量
        可选项：
            系列名
            最终更新日
            作者
            剧情
            插画
            声优
            对应语言
            ——————简介
            ——————评分

            ??版本更新情报
        */
        public readonly static String CSS = Resources.Resource1.WorkTemplate;
        public readonly static InfoTemplate[] localTemplates = new InfoTemplate[5];
        public readonly static Dictionary<String, RJInfo> RJInfoPool = new Dictionary<string, RJInfo>();

        public String RJNum;
        public String html;

        private HTMLParser p;
        public RJOutline outline;

        static RJInfo()
        {
            localTemplates[0] = new InfoTemplate("RJ Outline(ja_JP)");
            localTemplates[0].TemplateList.Add("名前", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].TemplateList.Add("サークル名", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].TemplateList.Add("画像", BaseInfoType.InfoType.InfoGroup);
            localTemplates[0].TemplateList.Add("販売日", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].TemplateList.Add("年齢指定", BaseInfoType.InfoType.RichText);
            localTemplates[0].TemplateList.Add("作品形式", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].TemplateList.Add("ファイル形式", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].TemplateList.Add("ジャンル", BaseInfoType.InfoType.Tag);
            localTemplates[0].TemplateList.Add("ファイル容量", BaseInfoType.InfoType.LiteralText);

            localTemplates[0].OptionalList.Add("シリーズ名", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("最終更新日", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("作者", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("シナリオ", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("イラスト", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("声優", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("対応言語", BaseInfoType.InfoType.LiteralText);
            localTemplates[0].OptionalList.Add("作品内容", BaseInfoType.InfoType.LiteralText);  //显示时转成html,结合CSS常量
            localTemplates[0].OptionalList.Add("評価", BaseInfoType.InfoType.LiteralText);


            localTemplates[1] = new InfoTemplate("RJ Outline(en_US)");
            localTemplates[1].TemplateList.Add("WorkName", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].TemplateList.Add("Circle", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].TemplateList.Add("Image", BaseInfoType.InfoType.InfoGroup);
            localTemplates[1].TemplateList.Add("Release date", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].TemplateList.Add("Age", BaseInfoType.InfoType.RichText);
            localTemplates[1].TemplateList.Add("Product format", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].TemplateList.Add("File format", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].TemplateList.Add("Genre", BaseInfoType.InfoType.Tag);
            localTemplates[1].TemplateList.Add("File size", BaseInfoType.InfoType.LiteralText);

            localTemplates[1].OptionalList.Add("Series name", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Last updated", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Author", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Scenario", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Illustration", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Voice Actor", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Supported languages", BaseInfoType.InfoType.LiteralText);
            localTemplates[1].OptionalList.Add("Product summary", BaseInfoType.InfoType.LiteralText);  //显示时转成html,结合CSS常量
            localTemplates[1].OptionalList.Add("Rating", BaseInfoType.InfoType.LiteralText);


            localTemplates[2] = new InfoTemplate("RJ Outline(zh_CN)");
            localTemplates[2].TemplateList.Add("作品名", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].TemplateList.Add("社团名", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].TemplateList.Add("封面图", BaseInfoType.InfoType.InfoGroup);
            localTemplates[2].TemplateList.Add("贩卖日", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].TemplateList.Add("年龄指定", BaseInfoType.InfoType.RichText);
            localTemplates[2].TemplateList.Add("作品类型", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].TemplateList.Add("文件形式", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].TemplateList.Add("分类", BaseInfoType.InfoType.Tag);
            localTemplates[2].TemplateList.Add("文件容量", BaseInfoType.InfoType.LiteralText);

            localTemplates[2].OptionalList.Add("系列名", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("最终更新日", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("作者", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("剧情", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("插画", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("声优", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("对应语言", BaseInfoType.InfoType.LiteralText);
            localTemplates[2].OptionalList.Add("作品内容", BaseInfoType.InfoType.LiteralText);  //显示时转成html,结合CSS常量
            localTemplates[2].OptionalList.Add("评价", BaseInfoType.InfoType.LiteralText);


            localTemplates[3] = new InfoTemplate("RJ Outline(zh_TW)");
            localTemplates[3].TemplateList.Add("作品名", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].TemplateList.Add("社團名", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].TemplateList.Add("封面圖", BaseInfoType.InfoType.InfoGroup);
            localTemplates[3].TemplateList.Add("販賣日", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].TemplateList.Add("年齡指定", BaseInfoType.InfoType.RichText);
            localTemplates[3].TemplateList.Add("作品形式", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].TemplateList.Add("檔案形式", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].TemplateList.Add("分類", BaseInfoType.InfoType.Tag);
            localTemplates[3].TemplateList.Add("檔案容量", BaseInfoType.InfoType.LiteralText);

            localTemplates[3].OptionalList.Add("系列名", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("最終更新日", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("作者", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("劇本", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("插畫", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("聲優", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("對應語言", BaseInfoType.InfoType.LiteralText);
            localTemplates[3].OptionalList.Add("作品內容", BaseInfoType.InfoType.LiteralText);  //显示时转成html,结合CSS常量
            localTemplates[3].OptionalList.Add("評價", BaseInfoType.InfoType.LiteralText);


            localTemplates[4] = new InfoTemplate("RJ Outline(ko_KR)");
            localTemplates[4].TemplateList.Add("이름", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].TemplateList.Add("서클명", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].TemplateList.Add("영상", BaseInfoType.InfoType.InfoGroup);
            localTemplates[4].TemplateList.Add("판매일", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].TemplateList.Add("연령 지정", BaseInfoType.InfoType.RichText);
            localTemplates[4].TemplateList.Add("작품 형식", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].TemplateList.Add("파일 형식", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].TemplateList.Add("장르", BaseInfoType.InfoType.Tag);
            localTemplates[4].TemplateList.Add("파일 용량", BaseInfoType.InfoType.LiteralText);

            localTemplates[4].OptionalList.Add("시리즈명", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("최종 갱신일", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("저자", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("시나리오", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("일러스트", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("성우", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("대응 언어", BaseInfoType.InfoType.LiteralText);
            localTemplates[4].OptionalList.Add("작품 내용", BaseInfoType.InfoType.LiteralText);  //显示时转成html,结合CSS常量
            localTemplates[4].OptionalList.Add("평가", BaseInfoType.InfoType.LiteralText);
        }

        protected RJInfo(String rj, String html) 
        {
            this.RJNum = rj;
            this.html = html;
            this.p = HTMLParser.GetByHTML(html);
            outline = new RJOutline(html);
            
        }

        public static RJInfo GetRJInfo(String rj, String html)
        {
            RJInfo info;

            if (RJInfoPool.ContainsKey(rj))
            {
                RJInfoPool[rj].html = html;
                info = RJInfoPool[rj];
            }
            else
            {
                info = new RJInfo(rj, html);
                RJInfoPool.Add(rj, info);
            }

            return info;
        }

        public static RJInfo GetRJInfo(String rj)
        {
            return GetRJInfo(rj, HTMLHelper.GetRJHTMLString(rj));
        }

        public InfoGroup<BaseInfoType> GetAllInfos()
        {
            InfoGroup<BaseInfoType> info = new InfoGroup<BaseInfoType>(RJNum);
            RJOutline outline = new RJOutline(html);
            Locale l = outline.GetLocale();

            String cache = LocaleTexts.InLang("作品名", l);
            info.InfoList.Add(cache, new LiteralText(cache, GetWorkName()));

            cache = LocaleTexts.InLang("封面图", l);
            InfoGroup<Picture> pics = new InfoGroup<Picture>(cache);
            int i = 0;
            foreach(Image pic in GetImages())
            {
                pics.InfoList.Add((i).ToString(), new Picture(i.ToString(), pic));
                i++;
            }
            info.InfoList.Add(cache, pics);

            cache = LocaleTexts.InLang("社团名", l);
            TagCollection tc = new TagCollection(cache);
            tc.AddTag(new Tag(GetCircleName()));
            info.InfoList.Add(cache, tc);

            foreach(BaseInfoType inf in outline.ToInfoGroup())
            {
                info.InfoList.Add(inf.Name, inf);
            }

            cache = LocaleTexts.InLang("作品内容", l);
            info.InfoList.Add(cache, new LiteralText(cache, GetSummary()));

            cache = LocaleTexts.InLang("评价", l);
            info.InfoList.Add(cache, new LiteralText(cache, GetRating()));

            return info;
        }

        /// <summary>
        /// 获取作品名
        /// </summary>
        /// <returns>作品名</returns>
        public String GetWorkName()
        {
            return p.GetFirstNode("id", "work_name").ToPlainTextStringEx().Trim();
        }

        /// <summary>
        /// 获取社团名
        /// </summary>
        /// <returns>社团名</returns>
        public String GetCircleName()
        {
            INode n = p.GetFirstNode("class", "maker_name");
            return n.ToPlainTextStringEx().Trim();
        }

        /// <summary>
        /// 获取封面图片组
        /// </summary>
        /// <returns>封面图片组</returns>
        public List<Image> GetImages()
        {
            List<Image> imageList = new List<Image>();

            return imageList;
        }

        /// <summary>
        /// 获取作品简介
        /// </summary>
        /// <returns>作品简介（HTML格式）</returns>
        public String GetSummary()
        {
            INode n = p.GetFirstNode("itemprop", "description");
            return n.ToHtml().Trim();
        }

        /// <summary>
        /// 获取作品评分
        /// </summary>
        /// <returns>作品评分</returns>
        public String GetRating()
        {
            return "";
        }

        
    }
}
