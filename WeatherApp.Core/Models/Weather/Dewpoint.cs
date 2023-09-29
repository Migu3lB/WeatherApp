using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather
{
    public class Dewpoint
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
