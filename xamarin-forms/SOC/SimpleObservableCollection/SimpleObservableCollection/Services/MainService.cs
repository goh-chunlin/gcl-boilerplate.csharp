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
        private ObservableCollection<ItemCollection> _allItems = new ObservableCollection<ItemCollection>();

        public ObservableCollection<ItemCollection> GetAllItems()
        {
            return _allItems;
        }

        public void AddItem(string name)
        {
            counter++;

            var addingList = new ItemCollection();
            addingList.Items = new ObservableCollection<Item>();
            for (int i = 0; i < counter; i++) 
            {
                addingList.Items.Add(new Item { Name = $"{name} {counter}" });
            }
            _allItems.Add(addingList);
        }

        public void UpdateItem(string id, string name)
        {
            var selectedItem = _allItems.FirstOrDefault(i => i.Items.Select(a => a.Id).Contains(id));

            foreach (var item in selectedItem.Items) 
            {
                item.Name = name;
                item.UpdateThis();
            }
            
        }

        public void DeleteItem(string id)
        {
            //var selectedItem = _allItems.SelectMany(a => a).FirstOrDefault(i => i.Id == id);
            //_allItems.Remove(selectedItem);
        }
    }
}
