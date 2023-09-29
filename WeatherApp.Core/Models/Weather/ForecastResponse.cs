using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather
{
    public class ForecastResponse
    {
        [JsonPropertyName("@context")]
        public List<object> Context { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; }

        [JsonPropertyName("properties")]
        public ForecastProperties Properties { get; set; }
    }
}
