using System.Runtime.Serialization;
using WTS.CommunityToolkit.EnumCombo.Core.EnumAttributes;

namespace WTS.CommunityToolkit.EnumCombo.Core.Enums
{
    public enum MyColors
    {
        [EnumMember(Value = "Red"),    RGB(138, 0, 16),   ColorChineseName("红色")] Red,
        [EnumMember(Value = "Green"),  RGB(26, 199, 72),  ColorChineseName("绿色")] Green,
        [EnumMember(Value = "Blue"),   RGB(26, 98, 199),  ColorChineseName("蓝色")] Blue,
        [EnumMember(Value = "Orange"), RGB(245, 189, 47), ColorChineseName("橙色")] Orange,
        [EnumMember(Value = "Pink"),   RGB(245, 47, 202), ColorChineseName("粉红")] Pink,
        [EnumMember(Value = "Black"),  RGB(0, 0, 0),      ColorChineseName("黑色")] Black
    }
}
