using System.Diagnostics.CodeAnalysis;
using AccuWeather.BFF.Interfaces.Agents;
using AccuWeather.BFF.Models.Locations.ApiResponses;
using AccuWeather.BFF.Models.Settings;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using Polly;

namespace AccuWeather.BFF.Agents;

[ExcludeFromCodeCoverage]
public class AccuWeatherApiAgent : IAccuWeatherApiAgent
{
    private readonly string? _apiToken;
    private readonly string? _apiUrl;

    public AccuWeatherApiAgent(IOptions<ApiSettings>config)
    {
        _apiToken = config.Value.ApiToken;
        _apiUrl = config.Value.UrlAccuWeather;
    }
    
    public async Task<List<CitySearchResponse>> GetLocationsByCity(string locationText)
    {
        var url = _apiUrl + "/locations/v1/cities/search";
        var queryValues = new Dictionary<string, string?>
        {
            {"apikey", _apiToken},
            { "q", locationText },
            { "language", "pt-br" }
        };
        
        var result = await Policy
            .Handle<FlurlHttpException>()
            .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(0.5))
            .ExecuteAsync(() =>
                    url
                    .SetQueryParams(queryValues)
                    .WithTimeout(5)
                    .GetAsync()
            ).ReceiveJson<List<CitySearchResponse>>();

        return result;
    }
    
    public async Task<CurrentConditionsResponse> GetLocationCurrentConditions(string cityKey)
    {
        var url = _apiUrl + "/currentconditions/v1/";
        var queryValues = new Dictionary<string, string?>
        {
            {"apikey", _apiToken},
            { "language", "pt-br" }
        };
        
        var result = await Policy
            .Handle<FlurlHttpException>()
            .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(0.5))
            .ExecuteAsync(() =>
                url
                    .AppendPathSegment(cityKey)
                    .SetQueryParams(queryValues)
                    .WithTimeout(5)
                    .GetAsync()
            ).ReceiveJson<List<CurrentConditionsResponse>>();

        return result.First();
    }
}