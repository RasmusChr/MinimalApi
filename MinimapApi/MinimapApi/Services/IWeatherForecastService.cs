namespace MinimapApi.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
} 