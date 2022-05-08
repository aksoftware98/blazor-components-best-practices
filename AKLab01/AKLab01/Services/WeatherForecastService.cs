using System.Net.Http.Json;
using static AKLab01.Pages.FetchData;

namespace AKLab01.Services
{

    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> FetchWeatherAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }

    public class DemoWeatherForecastService : IWeatherForecastService
    {
        public Task<WeatherForecast[]> FetchWeatherAsync()
        {
            return Task.FromResult(new WeatherForecast[]
            {
                new WeatherForecast { Date = DateTime.Now, Summary = "Cloudy", TemperatureC = 33 },
                new WeatherForecast { Date = DateTime.Now, Summary = "Sunny", TemperatureC = 31 },
                new WeatherForecast { Date = DateTime.Now, Summary = "Rainning", TemperatureC = 11 },
                new WeatherForecast { Date = DateTime.Now, Summary = "Snowing", TemperatureC = 1 },
            });
        }
    }
}
