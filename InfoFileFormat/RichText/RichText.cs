using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class RichText : BaseInfoType
    {
        enum ScriptType { Subscript = -1, Superscript = 1 ,Normal = 0 };
        Color foregroundColor = Color.Black;
        Color backgroundColor = Color.Transparent;
        String font = "Arial";
        float size = 9;
        bool bold = false;
        bool italic = false;
        bool deleteLine = false;
        bool underLine = false;
        ScriptType script = ScriptType.Normal;   //-1为下标，1为上标，0为正常
        String linkTo = null;   //超链接

        String text;
        
        public RichText(String text)
        {
            this.text = text;

            //UpdateTime();
        }

        public override InfoType GetInfoType()
        {
            return InfoType.RichText;
        }
    }
}
