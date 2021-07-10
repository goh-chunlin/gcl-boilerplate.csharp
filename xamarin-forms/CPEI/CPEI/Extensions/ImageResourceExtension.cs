using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CPEI.Extensions
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null) return null;

            Assembly assembly = typeof(ImageResourceExtension).Assembly;
            var imageSource = ImageSource.FromResource(Source, assembly);

            return imageSource;
        }
    }
}
