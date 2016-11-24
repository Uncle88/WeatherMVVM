﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVVM.ViewModels
{
    class WeatherViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string _inCityName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_inCityName));
        }

    }
}
