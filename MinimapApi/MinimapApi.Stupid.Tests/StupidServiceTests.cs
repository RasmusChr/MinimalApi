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
    public void GetStupid_ReturnsCorrectString()
    {
        // Arrange
        var expectedName = "carljakobsen";
        var expectedAge = DateTime.Now.Year - 1990;
        var expected = $"{expectedName} is {expectedAge} years old";

        // Act
        var result = _stupidService.GetStupid();

        // Assert
        Assert.Equal(expected, result);
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
    public void GetStupid_ContainsCorrectAge7()
    {
        // Arrange
        var expectedAge = DateTime.Now.Year - 1990;

        // Act
        var result = _stupidService.GetStupid7();

        // Assert
        Assert.Contains(expectedAge.ToString(), result);
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