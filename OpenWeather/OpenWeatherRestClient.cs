using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.OpenWeather
{
    public class OpenWeatherRestClient<T>
    {
        private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string Key = "f2015602cfe813aa811096b60e5f8bd0";

        HttpClient _httpClient = new HttpClient();

        public async Task<T> GetAllWeathers(string city)
        {
            var json = await _httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key);

            var getWeatherModels = JsonConvert.DeserializeObject<T>(json);

            return getWeatherModels;
        }
    }
}