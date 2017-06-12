﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFA.Localization;

namespace Localization.Demo
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        LanguageDictionary CurrentLang = LanguageDictionary.Current;

        private ObservableCollection<LanguageDictionary> cultures = new ObservableCollection<LanguageDictionary>();
       

        public ObservableCollection<LanguageDictionary> Cultures
        {
            get => cultures; set
            {
                cultures = value;
                OnPropertyChanged("Cultures");
            }
        }
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
