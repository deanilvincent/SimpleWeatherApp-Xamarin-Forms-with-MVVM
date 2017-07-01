using OpenWeatherSamp1.Models;
using OpenWeatherSamp1.ServicesHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OpenWeatherSamp1.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        WeatherServices _weatherServices = new WeatherServices();

        private WeatherMain _weatherMain;

        public WeatherMain WeatherMain
        {
            get { return _weatherMain; }
            set
            {
                _weatherMain = value;
                OnPropertyChanged();
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                InitializeGetWeatherAsync();
                OnPropertyChanged();
            }
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        //public Command GetWeatherCommand
        //{
        //    get
        //    {
        //        return new Command(async () => {
        //            await InitializeGetWeatherAsync();
        //        });
        //    }
        //}

        private async Task InitializeGetWeatherAsync()
        {
            try
            {
                IsBusy = true;
                WeatherMain = await _weatherServices.GetWeatherDetails(_city);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
