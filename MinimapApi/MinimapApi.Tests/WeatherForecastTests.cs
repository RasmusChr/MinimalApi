using MinimapApi.Services;
using Xunit;

namespace MinimapApi.Tests;

public class WeatherForecastServiceTests
{
    [Fact]
    public void GetForecast_ReturnsFiveForecasts()
    {
        // Arrange
        var service = new WeatherForecastService();

        // Act
        var result = service.GetForecast();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count());
    }
    
    [Fact]
    public void GetForecast_ReturnsFiveForecasts2()
    {
        // Arrange
        var service = new WeatherForecastService();

        // Act
        var result = service.GetForecast2();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count());
    }


    [Fact]
    public void GetForecast_ReturnsValidForecasts()
    {
        // Arrange
        var service = new WeatherForecastService();

        // Act
        var result = service.GetForecast();

        // Assert
        foreach (var forecast in result)
        {
            Assert.InRange(forecast.TemperatureC, -20, 55);
        }
    }
}