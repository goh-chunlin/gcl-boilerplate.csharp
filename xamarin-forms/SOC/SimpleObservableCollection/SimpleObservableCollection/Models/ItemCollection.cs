using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SimpleObservableCollection.Models
{
    public class ItemCollection : INotifyPropertyChanged
    {
        public ObservableCollection<Item> Items { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
