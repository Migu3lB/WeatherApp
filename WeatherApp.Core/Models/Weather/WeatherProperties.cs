using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather
{
    public class WeatherProperties
    {

        [JsonPropertyName("forecast")]
        public string Forecast { get; set; }
    }
}
