using System;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Core.Interfaces;
using WeatherApp.Core.Models.Geocoding;

namespace WeatherApp.Infrastructure.ExternalServices
{
    public class GeocodingService : IGeocodingService
    {
        private readonly HttpClient _httpClient;

        public GeocodingService(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<Location> GetLocationAsync(string address)
        {
            try
            {
                string apiUrl = $"https://geocoding.geo.census.gov/geocoder/geographies/onelineaddress?address={Uri.EscapeDataString(address)}&benchmark=2020&vintage=2010&format=json";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    GeocodingResponse geocodingResponse = JsonSerializer.Deserialize<GeocodingResponse>(responseContent);

                    if (geocodingResponse?.result?.addressMatches?.Length > 0)
                    {
                        var coordinates = geocodingResponse.result.addressMatches[0].coordinates;

                        var location = new Location
                        {
                            Latitude = coordinates.y.ToString("F6", CultureInfo.InvariantCulture),
                            Longitude = coordinates.x.ToString("F6", CultureInfo.InvariantCulture),
                        };

                        return location;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
