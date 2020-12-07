using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateStudio.DependencyInjection.ViewModels;

namespace WindowsTemplateStudio.DependencyInjection.Views
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
