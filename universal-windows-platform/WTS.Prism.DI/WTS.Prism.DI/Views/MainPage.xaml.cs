using System;

using Windows.UI.Xaml.Controls;

using WTS.Prism.DI.ViewModels;

namespace WTS.Prism.DI.Views
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
