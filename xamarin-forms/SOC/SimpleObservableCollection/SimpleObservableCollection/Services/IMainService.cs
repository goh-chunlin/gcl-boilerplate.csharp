using SimpleObservableCollection.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimpleObservableCollection.Services
{
    public interface IMainService
    {
        ObservableCollection<ItemCollection> GetAllItems();

        void AddItem(string name);

        void UpdateItem(string id, string name);

        void DeleteItem(string id);
    }
}
