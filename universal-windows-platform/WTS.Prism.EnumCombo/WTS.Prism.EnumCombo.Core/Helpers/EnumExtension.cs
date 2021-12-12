using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using WTS.Prism.EnumCombo.Core.EnumAttributes;
using WTS.Prism.EnumCombo.Core.Enums;

namespace WTS.Prism.EnumCombo.Core.Helpers
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public static Color GetColor(this MyColors value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (RGBAttribute[])fi.GetCustomAttributes(typeof(RGBAttribute), false);
            if (attributes.Length > 0)
                return attributes[0].Color;
            else
                return Color.White;
        }
    }
}
