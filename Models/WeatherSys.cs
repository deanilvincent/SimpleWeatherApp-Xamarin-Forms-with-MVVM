using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.Models
{
    public class WeatherSys
    {
        [JsonProperty("country")]
        public string country { get; set; }
    }
}
