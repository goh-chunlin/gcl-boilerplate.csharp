using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WTS.Prism.EnumCombo.Core.EnumAttributes;

namespace WTS.Prism.EnumCombo.Core.Enums
{
    public enum MyColors
    {
        [Description("Red:红色"), RGB(138, 0, 16)] Red,
        [Description("Green:绿色"), RGB(26, 199, 72)] Green,
        [Description("Blue:蓝色"), RGB(26, 98, 199)] Blue,
        [Description("Orange:橙色"), RGB(245, 189, 47)] Orange,
        [Description("Pink:粉红"), RGB(245, 47, 202)] Pink,
        [Description("Black:黑色"), RGB(0, 0, 0)] Black
    }
}
