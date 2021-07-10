using SimpleObservableCollection.Models;
using SimpleObservableCollection.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleObservableCollection.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMainService _mainService;

        public MainViewModel(IMainService mainService)
        {
            _mainService = mainService;
        }

        public ObservableCollection<ItemCollection> Items => _mainService.GetAllItems();

        public ICommand AddNewItemCommand => new Command(
            execute: () =>
            {
                _mainService.AddItem("New Item");
            });

        public ICommand EditItemCommand => new Command<string>(
            execute: (id) =>
            {
                _mainService.UpdateItem(id, $"Updated Item at {DateTime.Now}");
            });

        public ICommand DeleteItemCommand => new Command<string>(
            execute: (id) =>
            {
                _mainService.DeleteItem(id);
            });
    }
}
