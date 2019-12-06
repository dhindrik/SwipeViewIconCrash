using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SwipeViewIconCrash
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Cars { get; set; } = new ObservableCollection<string>(new List<string>()
        {
            "Audi",
            "BMW",
            "Mercedes",
            "Volvo",
            "Opel",
            "Skoda",
            "Volkswagen"
        });
 
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
