﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SummitWeather.Models;

namespace SummitWeather.ViewModels
{

    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            CurrentWeather = null;

            var locations = App.Database.GetItems();

            Locations = new ObservableCollection<SavedLocation>(locations);
        }

        
        public WeatherModel CurrentWeather { get; set; }
        public ObservableCollection<SavedLocation> Locations { get; set; }
        public string Zip { get; set; }
    }

}
