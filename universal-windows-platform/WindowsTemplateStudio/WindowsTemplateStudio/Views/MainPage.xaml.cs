using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateStudio.ViewModels;

namespace WindowsTemplateStudio.Views
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
