using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    class RichTextParagraph : BaseInfoType
    {
        public List<BaseInfoType> Paragraph { get; } = new List<BaseInfoType>();
    }
}
