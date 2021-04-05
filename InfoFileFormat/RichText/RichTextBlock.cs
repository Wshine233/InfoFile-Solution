using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class RichTextBlock : BaseInfoType
    {
        public List<RichTextParagraph> DataBlock { get; } = new List<RichTextParagraph>();

        

        public override InfoType GetInfoType()
        {
            return InfoType.RichText;
        }
    }
}
