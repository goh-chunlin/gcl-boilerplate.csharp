using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Windows.Mvvm;
using WTS.Prism.DI.Core.Interfaces;

namespace WTS.Prism.DI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Fields
        private readonly ICustomService _customService;

        private ICommand _mainButtonClickedCommand;

        private int _count;
        private string _demoMessage;
        #endregion

        #region Public Properties
        public string DemoMessage
        {
            get { return _demoMessage; }
            set { SetProperty(ref _demoMessage, value); }
        }
        #endregion

        public MainViewModel(ICustomService customService)
        {
            _customService = customService;
        }

        public ICommand MainButtonClickedCommand => _mainButtonClickedCommand ?? (_mainButtonClickedCommand = new DelegateCommand(OnMainButtonClicked));

        private void OnMainButtonClicked()
        {
            _count++;

            DemoMessage = _customService.GetDemoText(_count);
        }
    }
}
