using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVVM.ViewModels
{
    class FavoriteWeatherViewModel : WeatherViewModelBase
    {
        FavoriteWeatherViewModel() { }

        private double _wind;
        private double _cloudiness;
        private double _pressure;
        private double _humidity;
        private DateTime _sunrise;
        private DateTime _sunset;
        private double _geoCoord;


    }
}
