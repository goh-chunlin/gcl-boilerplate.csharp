using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WTS.Prism.EnumCombo.Core.EnumAttributes
{
    public class RGBAttribute : Attribute
    {
        public Color Color;

        public RGBAttribute(int r, int g, int b) { Color = Color.FromArgb(r, g, b); }
    }
}
