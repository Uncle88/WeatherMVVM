using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMVVM.Views;
using Xamarin.Forms;

namespace WeatherMVVM.ViewModels 
{
    class MainWeatherViewModel : WeatherViewModelBase
    {
        private INavigation _navigation;

        public MainWeatherViewModel(INavigation navigation)
        {
            _navigation = navigation;
           // _clickCommand = new Command;
        }

        public MainWeatherViewModel()
        {
        }

        public Command ClickCommand
        {
            get {
                return _clickCommand ?? (_clickCommand = new Command( async () =>
           {
               await _navigation.PushAsync(new FavoriteWeatherView());

           }));
            }
        }

        private Command _clickCommand;
        private string _inCityName;

        private string _wind;
        private string _cloudiness;
        private string _pressure;
        private string _humidity;
        private string _sunrise;
        private string _sunset;
        private double _geoCoord;

        public string InCityName
        {
            get { return _inCityName; }
            set { _inCityName = value;
                OnPropertyChanged(nameof(InCityName));
            }
        }

    }
}
