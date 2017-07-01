using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.Models
{
    public class WeatherWindDetails
    {
        [JsonProperty("speed")]
        public string speed { get; set; }
    }
}
