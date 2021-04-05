using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupModal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimplePopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public SimplePopupPage()
        {
            InitializeComponent();
        }

        private async void ClosePopupButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}