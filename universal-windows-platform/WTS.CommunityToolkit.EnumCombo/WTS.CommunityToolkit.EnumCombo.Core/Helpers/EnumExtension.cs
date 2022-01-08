using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using WTS.CommunityToolkit.EnumCombo.Core.EnumAttributes;
using WTS.CommunityToolkit.EnumCombo.Core.Enums;

namespace WTS.CommunityToolkit.EnumCombo.Core.Helpers
{
    public static class EnumExtension
    {
        public static Color GetColor(this MyColors value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (RGBAttribute[])fi.GetCustomAttributes(typeof(RGBAttribute), false);

            if (attributes.Length == 0) return Color.White;

            return attributes[0].Color;            
        }

        public static string GetColorChineseName(this MyColors value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (ColorChineseNameAttribute[])fi.GetCustomAttributes(typeof(ColorChineseNameAttribute), false);

            if (attributes.Length == 0) return string.Empty;

            return attributes[0].ChineseName;
        }
    }
}
