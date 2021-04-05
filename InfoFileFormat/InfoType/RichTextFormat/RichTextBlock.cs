using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    class RichTextBlock : BaseInfoType
    {
        public List<RichTextParagraph> DataBlock { get; } = new List<RichTextParagraph>();
        
        
    }
}
