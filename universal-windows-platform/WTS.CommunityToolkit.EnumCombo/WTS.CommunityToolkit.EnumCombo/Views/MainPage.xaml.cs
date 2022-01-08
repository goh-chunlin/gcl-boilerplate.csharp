using System;

using Windows.UI.Xaml.Controls;

using WTS.CommunityToolkit.EnumCombo.ViewModels;

namespace WTS.CommunityToolkit.EnumCombo.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
