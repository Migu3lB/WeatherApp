using System.Threading.Tasks;
using WeatherApp.Core.Models.Weather;

namespace WeatherApp.Core.Interfaces
{
    public interface IWeatherService
    {
        Task<ForecastResponse> GetWeatherForecastAsync(string latitude, string longitude);
    }
}
