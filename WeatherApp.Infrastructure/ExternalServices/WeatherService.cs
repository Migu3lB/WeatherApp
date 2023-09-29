using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Core.Interfaces;
using WeatherApp.Core.Models;
using WeatherApp.Core.Models.Weather;

namespace WeatherApp.Infrastructure.ExternalServices
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<ForecastResponse> GetWeatherForecastAsync(string latitude, string longitude)
        {
            try
            {
                string apiUrl = $"https://api.weather.gov/points/{latitude},{longitude}";
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "WeatherApp");

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var forecast = JsonSerializer.Deserialize<WeatherForecast>(json);

                    string forecastUrl = forecast.Properties.Forecast;

                    _httpClient.DefaultRequestHeaders.Add("User-Agent", $"WeatherApp User{new Random().Next(1000, 9999)}");
                    var forecastResponse = await _httpClient.GetAsync(forecastUrl);

                    if (forecastResponse.IsSuccessStatusCode)
                    {
                        var forecastJson = await forecastResponse.Content.ReadAsStringAsync();
                        var detailedForecast = JsonSerializer.Deserialize<ForecastResponse>(forecastJson);

                        return detailedForecast;
                    }
                    else
                    {
                        throw new HttpRequestException("Error al obtener el pronóstico detallado.");
                    }
                }
                else
                {
                    throw new HttpRequestException("Error al obtener el punto de pronóstico.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de deserialización JSON: {ex.Message}");
                return null;
            }
        }
    }
}
