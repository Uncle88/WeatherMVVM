using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherMVVM.Views
{
    public partial class MyWeatherView : ContentPage
    {
        public MyWeatherView()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MyWeatherViewModel();
        }
    }
}
