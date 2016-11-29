using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherMVVM.Views;
using Xamarin.Forms;

namespace WeatherMVVM
{
    public class App : Application
    {
        public Page GetMainWeatherView()
        {
            // The root page of your application
            return new NavigationPage (new MainWeatherView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
