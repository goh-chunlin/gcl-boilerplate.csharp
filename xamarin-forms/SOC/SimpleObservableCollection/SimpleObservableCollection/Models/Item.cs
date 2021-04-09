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

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;

                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
