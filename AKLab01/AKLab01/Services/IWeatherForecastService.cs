using static AKLab01.Pages.FetchData;

namespace AKLab01.Services
{
    public interface IWeatherForecastService 
    {

        Task<WeatherForecast[]> FetchWeatherAsync(); 

    }
}
