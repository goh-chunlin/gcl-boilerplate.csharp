using System;
using System.Drawing;

namespace WTS.CommunityToolkit.EnumCombo.Core.EnumAttributes
{
    public class RGBAttribute : Attribute
    {
        public Color Color;

        public RGBAttribute(int r, int g, int b) { Color = Color.FromArgb(r, g, b); }
    }
}
