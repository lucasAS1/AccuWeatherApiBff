using AccuWeather.BFF.Interfaces.Agents;
using AccuWeather.BFF.Interfaces.Services;
using AccuWeather.BFF.Models.Locations.Response;
using AutoMapper;

namespace AccuWeather.BFF.Services;

public class AccuWeatherService : IAccuWeatherService
{
    private readonly IAccuWeatherApiAgent _apiAgent;
    private readonly IMapper _mapper;

    public AccuWeatherService(IAccuWeatherApiAgent apiAgent, IMapper mapper)
    {
        _apiAgent = apiAgent;
        _mapper = mapper;
    }

    public async Task<List<CidadeResponse>> GetCitiesByTextAsync(string? city)
    {
        var locationResponse = await _apiAgent.GetLocationsByCity(city);

        var result = _mapper.Map<List<CidadeResponse>>(locationResponse);

        return result;
    }

    public async Task<TempoResponse> GetCurrentConditionsByLocationKeyAsync(string locationKey)
    {
        var locationResponse = await _apiAgent.GetLocationCurrentConditions(locationKey);

        var result = _mapper.Map<TempoResponse>(locationResponse);

        return result;
    }
}