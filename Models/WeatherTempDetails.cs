using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.Models
{
    public class WeatherTempDetails
    {
        [JsonProperty("temp")]
        public string temp { get; set; }

        [JsonProperty("humidity")]
        public string humidity { get; set; }
    }
}
