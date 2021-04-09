using SimpleObservableCollection.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SimpleObservableCollection.Services
{
    public class MainService : IMainService
    {
        private int counter;
        private ObservableCollection<Item> _allItems = new ObservableCollection<Item>();

        public ObservableCollection<Item> GetAllItems()
        {
            return _allItems;
        }

        public void AddItem(string name)
        {
            counter++;
            _allItems.Add(new Item { Name = $"{name} {counter}" });
        }

        public void UpdateItem(string id, string name)
        {
            var selectedItem = _allItems.FirstOrDefault(i => i.Id == id);
            selectedItem.Name = name;
        }

        public void DeleteItem(string id)
        {
            var selectedItem = _allItems.FirstOrDefault(i => i.Id == id);
            _allItems.Remove(selectedItem);
        }
    }
}
