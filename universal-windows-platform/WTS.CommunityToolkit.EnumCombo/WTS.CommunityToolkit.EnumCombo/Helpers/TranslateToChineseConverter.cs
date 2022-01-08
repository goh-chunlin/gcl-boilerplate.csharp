using System;
using Windows.UI.Xaml.Data;
using WTS.CommunityToolkit.EnumCombo.Core.Enums;
using WTS.CommunityToolkit.EnumCombo.Core.Helpers;

namespace WTS.CommunityToolkit.EnumCombo.Helpers
{
    public sealed class TranslateToChineseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((MyColors)value).GetColorChineseName();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
