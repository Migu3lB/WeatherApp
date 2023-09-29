using Microsoft.AspNetCore.Mvc;
using WeatherApp.Core.Interfaces;
using WeatherApp.Core.Models.Weather.DTO;
using WeatherApp.Core.Models.Weather;
using WeatherApp.Core.Models.Geocoding;
using System.Text.Json;

namespace WeatherApp.API.Controllers
{
    [Route("api/geocoding")]
    [ApiController]
    public class GeocodingController : ControllerBase
    {
        private readonly IGeocodingService _geocodingService;
        private readonly IWeatherService _weatherService;

        public GeocodingController(IGeocodingService geocodingService, IWeatherService weatherService)
        {
            _geocodingService = geocodingService;
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("location")]
        public async Task<IActionResult> GetLocationAsync(string address)
        {
            Location location = await _geocodingService.GetLocationAsync(address);

            if (location == null)
            {
                return NotFound();
            }

            ForecastResponse forecasts = await _weatherService.GetWeatherForecastAsync(location.Latitude, location.Longitude);

            if (forecasts == null)
            {
                string forecastMockFile = Path.Combine("Utilities", "forecastMockData.json");
                string jsonForecastMockData = System.IO.File.ReadAllText(forecastMockFile);
                forecasts = JsonSerializer.Deserialize<ForecastResponse>(jsonForecastMockData);
            }

            var forecastResponseDTO = new ForecastResponseDTO
            {
                Periods = forecasts.Properties.Periods,
            };

            return Ok(forecastResponseDTO);
        }
    }
}
