using Prism.Windows.Mvvm;
using Windows.UI;
using Windows.UI.Xaml.Media;
using WTS.Prism.EnumCombo.Core.Enums;
using WTS.Prism.EnumCombo.Core.Helpers;

namespace WTS.Prism.EnumCombo.ViewModels
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
