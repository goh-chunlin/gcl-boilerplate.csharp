using PopupModal.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupModal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ShowPopupButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new SimplePopupPage());
        }
    }
}
