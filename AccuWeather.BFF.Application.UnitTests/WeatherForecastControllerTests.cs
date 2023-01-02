using System.Collections.Generic;
using System.Threading.Tasks;
using AccuWeather.BFF.Interfaces.Services;
using AccuWeather.BFF.Models.Locations.Response;
using AccuWeather.BFF.WebApi.Controllers;
using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace AccuWeather.BFF.Application.UnitTests;

public class WeatherForecastControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IAccuWeatherService> _mockService;
    
    
    public WeatherForecastControllerTests()
    {
        _mockService = new Mock<IAccuWeatherService>();
        _fixture = new Fixture();
        
        _fixture.Customize(new AutoMoqCustomization() { ConfigureMembers = true });
    }

    private void ConfigurarMocks()
    {
        _mockService.Setup(
            x => x.GetCitiesByTextAsync(It.IsAny<string>()
            )
        ).ReturnsAsync(_fixture.Create<List<CidadeResponse>>());
        
        _mockService.Setup(
            x => x.GetCurrentConditionsByLocationKeyAsync(It.IsAny<string>()
            )
        ).ReturnsAsync(_fixture.Create<TempoResponse>());
    }
    
    [Fact]
    public async Task ShouldGetCityAndCurrentConditionCorrectly()
    {
        var uat = new WeatherForecastController(_mockService.Object);
        ConfigurarMocks();

        var result = await uat.GetCityAndCurrentCondition("TesteLandia");

        result.Should().BeOfType<OkObjectResult>();
    }
    
    [Fact]
    public async Task ShouldGetCityKeyCorrectly()
    {
        var uat = new WeatherForecastController(_mockService.Object);
        ConfigurarMocks();

        var result = await uat.GetCityKey("TesteLandia");

        result.Should().BeOfType<OkObjectResult>();
    }
    
    [Fact]
    public async Task ShouldGetCityCurrentConditionCorrectly()
    {
        var uat = new WeatherForecastController(_mockService.Object);
        ConfigurarMocks();

        var result = await uat.GetCityCurrentCondition("TesteLandia");

        result.Should().BeOfType<OkObjectResult>();
    }
}