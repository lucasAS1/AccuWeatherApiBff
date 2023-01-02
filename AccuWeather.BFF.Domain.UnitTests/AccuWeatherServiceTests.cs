using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccuWeather.BFF.Agents.Mapping;
using AccuWeather.BFF.Interfaces.Agents;
using AccuWeather.BFF.Models.Locations.ApiResponses;
using AccuWeather.BFF.Models.Locations.Response;
using AccuWeather.BFF.Services;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using Moq;
using Xunit;

namespace AccuWeather.BFF.Domain.UnitTests;

public class AccuWeatherServiceTests
{
    private readonly Mock<IAccuWeatherApiAgent> _mockApiAgent;
    private readonly IMapper _mapper;
    private readonly IFixture _fixture;
    
    public AccuWeatherServiceTests()
    {
        _mockApiAgent = new Mock<IAccuWeatherApiAgent>();
        _mapper = new Mapper(
            new MapperConfiguration(cfg => cfg.AddProfile<InfraDataPersistenceProfile>()));
        _fixture = new Fixture();
        
        _fixture.Customize(new AutoMoqCustomization() { ConfigureMembers = true });
    }

    private void ConfigureMock()
    {
        _mockApiAgent.Setup(
            x => x.GetLocationsByCity(It.IsAny<string>()
            )
        ).ReturnsAsync(_fixture.CreateMany<CitySearchResponse>().ToList());
        
        _mockApiAgent.Setup(
            x => x.GetLocationCurrentConditions(It.IsAny<string>()
            )
        ).ReturnsAsync(_fixture.Create<CurrentConditionsResponse>());
    }
    
    [Fact]
    public async Task ShouldGetCitiesByTextAsyncCorrectly()
    {
        ConfigureMock();
        var uat = new AccuWeatherService(_mockApiAgent.Object, _mapper);

        var result = await uat.GetCitiesByTextAsync("Testelandia");

        result.Should().BeOfType<List<CidadeResponse>>();
    }

    [Fact]
    public async Task ShouldGetCurrentConditionsByLocationKeyAsyncCorrectly()
    {
        ConfigureMock();
        var uat = new AccuWeatherService(_mockApiAgent.Object, _mapper);

        var result = await uat.GetCurrentConditionsByLocationKeyAsync("41604");

        result.Should().BeOfType<TempoResponse>();
    }
}