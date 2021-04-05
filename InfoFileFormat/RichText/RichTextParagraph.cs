using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public class RichTextParagraph : BaseInfoType
    {
        public List<BaseInfoType> Paragraph { get; } = new List<BaseInfoType>();

        public override InfoType GetInfoType()
        {
            return InfoType.RichText;
        }
    }
}
