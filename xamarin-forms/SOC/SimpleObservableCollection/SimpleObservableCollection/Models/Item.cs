using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleObservableCollection.Models
{
    public class Item : INotifyPropertyChanged
    {
        private string _name;

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string NameWithPrefix => $"Mr {Name}";

        public void UpdateThis() 
        {
            OnPropertyChanged("Name");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
