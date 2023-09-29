using WeatherApp.Core.Models.Geocoding;

namespace WeatherApp.Core.Interfaces
{
    public interface IGeocodingService
    {
        Task<Location> GetLocationAsync(string address);
    }
}
