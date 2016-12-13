using Android.Content.Res;
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
        public MainWeatherViewModel()
        {
            _clickCommand = new Command(ToFavoriteWeatherView);
        }

        private async void ToFavoriteWeatherView()
        {
            await Navigation.PushAsync(new FavoriteWeatherView()); 
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

        public Command ClickCommand
        {
            get {
                return _clickCommand ?? (_clickCommand = new Command(() =>
           {
               
           }));
            }
        }
    }
}
