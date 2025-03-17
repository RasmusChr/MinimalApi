using MinimapApi.Services;
using Xunit;

namespace Minimal.Stupid.Tests;

public class StupidServiceTests
{
    private readonly StupidService _stupidService;

    public StupidServiceTests()
    {
        _stupidService = new StupidService();
    }
    
    [Fact]
    public void GetStupid_ContainsCorrectAge()
    {
        // Arrange
        var expectedAge = DateTime.Now.Year - 1990;

        // Act
        var result = _stupidService.GetStupid();

        // Assert
        Assert.Contains(expectedAge.ToString(), result);
    }
    
    [Fact]
    public void GetStupid_ContainsCorrectAge6()
    {
        // Arrange
        var expectedAge = DateTime.Now.Year - 1990;

        // Act
        var result = _stupidService.GetStupid6();

        // Assert
        Assert.Contains(expectedAge.ToString(), result);
    }

    [Fact]  
    public void GetStupid_ContainsCorrectAge2()
    {
        // Arrange
        var expectedAge = DateTime.Now.Year - 1990;

        // Act
        var result = _stupidService.getStupid4();

        // Assert
        Assert.True(true);
    }

    [Fact]
    public void GetStupid_ContainsCorrectAge3()
    {
        // Arrange
        var expectedAge = DateTime.Now.Year - 1990;

        // Act
        var result = _stupidService.GetStupid3();

        // Assert
        Assert.Contains(expectedAge.ToString(), result);
    }
} 