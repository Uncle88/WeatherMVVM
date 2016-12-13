using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMVVM.ViewModels;
using Xamarin.Forms;

namespace WeatherMVVM.Views
{
    public partial class MainWeatherView : ContentPage
    {
        public MainWeatherView()
        {
            InitializeComponent();
            BindingContext = new MainWeatherViewModel(this.Navigation);
        }

    }
}
