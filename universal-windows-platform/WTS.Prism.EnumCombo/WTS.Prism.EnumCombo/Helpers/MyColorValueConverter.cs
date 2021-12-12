using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using WTS.Prism.EnumCombo.Core.Enums;
using WTS.Prism.EnumCombo.Core.Helpers;

namespace WTS.Prism.EnumCombo.Helpers
{
    public class MyColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is MyColors color)
            {
                return color.GetDescription();
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string s)
            {
                return Enum.Parse(typeof(MyColors), s.Substring(0, s.IndexOf(':')));
            }
            return null;
        }

        public string[] Strings => GetStrings();

        public static string[] GetStrings()
        {
            List<string> list = new List<string>();
            foreach (MyColors color in Enum.GetValues(typeof(MyColors)))
            {
                list.Add(color.GetDescription());
            }

            return list.ToArray();
        }
    }
}
