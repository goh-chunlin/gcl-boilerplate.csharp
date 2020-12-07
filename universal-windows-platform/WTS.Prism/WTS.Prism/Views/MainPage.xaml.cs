using System;

using Windows.UI.Xaml.Controls;

using WTS.Prism.ViewModels;

namespace WTS.Prism.Views
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
