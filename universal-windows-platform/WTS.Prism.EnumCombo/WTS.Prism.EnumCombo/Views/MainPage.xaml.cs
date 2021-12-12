using System;

using Windows.UI.Xaml.Controls;

using WTS.Prism.EnumCombo.ViewModels;

namespace WTS.Prism.EnumCombo.Views
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
