using OpenWeatherSamp1.Models;
using OpenWeatherSamp1.OpenWeather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.ServicesHandler
{
    public class WeatherServices
    {
        OpenWeatherRestClient<WeatherMain> _openWeatherRest = new OpenWeatherRestClient<WeatherMain>();

        public async Task<WeatherMain> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(city);

            return getWeatherDetails;
        }
    }
}
