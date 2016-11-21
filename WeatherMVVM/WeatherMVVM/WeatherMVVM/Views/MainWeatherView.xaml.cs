using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherMVVM.Views
{
    public partial class MainWeatherView : ContentPage
    {
        public MainWeatherView()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MainWeatherViewModel();
        }
    }
}
