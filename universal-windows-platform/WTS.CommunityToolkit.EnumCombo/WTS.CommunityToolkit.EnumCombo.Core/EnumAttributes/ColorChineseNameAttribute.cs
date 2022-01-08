using System;
using System.Collections.Generic;
using System.Text;

namespace WTS.CommunityToolkit.EnumCombo.Core.EnumAttributes
{
    public class ColorChineseNameAttribute : Attribute
    {
        public string ChineseName;

        public ColorChineseNameAttribute(string chineseText) { ChineseName = chineseText; }
    }
}
