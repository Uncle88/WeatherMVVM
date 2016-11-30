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

        public string InCityName
        {
            get { return _inCityName; }
            set { _inCityName = value;
                OnPropertyChanged(nameof(InCityName));
            }
        }

    }
}
