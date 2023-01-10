using AccuWeather.BFF.Models.Locations.Response;

namespace AccuWeather.BFF.Interfaces.Services;

public interface IAccuWeatherService
{
    Task<List<CidadeResponse>> GetCitiesByTextAsync(string? city);
    Task<TempoResponse> GetCurrentConditionsByLocationKeyAsync(string locationKey);
}