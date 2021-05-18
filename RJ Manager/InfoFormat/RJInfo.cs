using InfoFileFormat;
using RJ_Manager.HTMLProcesser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    
    public static class RJInfo
    {
        /*共有项：
            作品名
            社团名
            预览图（组）
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
            简介
            评分
        */
        public readonly static String CSS = Resources.Resource1.WorkTemplate;

        public readonly static InfoTemplate[] localTemplates = new InfoTemplate[5];

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


        public static String GetWorkName(String html)
        {
            HTMLParser p = HTMLParser.GetByHTML(html);

            return p.GetFirstNode("id", "work_name").ToPlainTextStringEx().Trim();
        } 
    }
}
