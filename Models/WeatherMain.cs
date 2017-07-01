using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherSamp1.Models
{
    public class WeatherMain
    {
        [JsonProperty("name")]
        public string name { get; set; }
        
        public WeatherTempDetails main { get; set; }

        public List<WeatherDetails> weather { get; set; }

        public WeatherWindDetails wind { get; set; }

        public WeatherSys sys { get; set; }
    }
}
