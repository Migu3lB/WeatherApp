using System.Text.Json.Serialization;

namespace WeatherApp.Core.Models.Weather
{
    public class WeatherForecast
    {
        [JsonPropertyName("@context")]
        public List<object> Context { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; }

        [JsonPropertyName("properties")]
        public WeatherProperties Properties { get; set; }
    }
}
