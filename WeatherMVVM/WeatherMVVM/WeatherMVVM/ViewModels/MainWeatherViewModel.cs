using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherMVVM.ViewModel
{
    class MainWeatherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWeatherViewModel() { }

        private Command _clickCommand;
        private string _inCityName;

        public string InCityName
        {
            get { return _inCityName; }
            set { _inCityName = value;
                OnPropertyChanged(nameof(InCityName));
            }
        }

        private void OnPropertyChanged(string _inCityName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(_inCityName));
        }

        public Command ClickCommand
        {
            get {
                return _clickCommand ?? (_clickCommand = new Command(() =>
           {
                //I don't known(((
           }));
            }
        }
    }
}
