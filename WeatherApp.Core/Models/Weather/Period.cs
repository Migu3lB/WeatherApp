using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather
{
    public class Period
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTimeOffset EndTime { get; set; }

        [JsonPropertyName("isDaytime")]
        public bool IsDaytime { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonPropertyName("temperatureTrend")]
        public object TemperatureTrend { get; set; }

        [JsonPropertyName("probabilityOfPrecipitation")]
        public Precipitation ProbabilityOfPrecipitation { get; set; }

        [JsonPropertyName("dewpoint")]
        public Dewpoint Dewpoint { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public RelativeHumidity RelativeHumidity { get; set; }

        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        [JsonPropertyName("windDirection")]
        public string WindDirection { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("shortForecast")]
        public string ShortForecast { get; set; }

        [JsonPropertyName("detailedForecast")]
        public string DetailedForecast { get; set; }
    }
}
