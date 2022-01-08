using Windows.UI;
using Windows.UI.Xaml.Media;
using Prism.Windows.Mvvm;
using WTS.CommunityToolkit.EnumCombo.Core.Enums;
using WTS.CommunityToolkit.EnumCombo.Core.Helpers;

namespace WTS.CommunityToolkit.EnumCombo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private MyColors _selectedColor = MyColors.Black;

        public MainViewModel()
        {
        }

        public MyColors SelectedColor
        {
            get => _selectedColor;
            set
            {
                if (_selectedColor != value)
                {
                    SetProperty(ref _selectedColor, value);
                    RaisePropertyChanged("FontColor");
                }
            }
        }

        public Brush FontColor => new SolidColorBrush(
            Color.FromArgb(255, _selectedColor.GetColor().R, _selectedColor.GetColor().G, _selectedColor.GetColor().B));
    }
}
