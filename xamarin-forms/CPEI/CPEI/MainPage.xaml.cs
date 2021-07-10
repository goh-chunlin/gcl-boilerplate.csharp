using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPEI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int imageIndex = rnd.Next(1, 8);

            MainImage.Source = ImageSource.FromResource(
                $"CPEI.Images.Genshin-Impact-Pic{imageIndex:00}.png",
                typeof(MainPage).Assembly);
        }
    }
}
