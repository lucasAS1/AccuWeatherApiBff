using AccuWeather.BFF.Models.Locations.ApiResponses;

namespace AccuWeather.BFF.Interfaces.Agents;

public interface IAccuWeatherApiAgent
{
    Task<List<CitySearchResponse>> GetLocationsByCity(string? locationText);
    Task<CurrentConditionsResponse> GetLocationCurrentConditions(string cityKey);
}