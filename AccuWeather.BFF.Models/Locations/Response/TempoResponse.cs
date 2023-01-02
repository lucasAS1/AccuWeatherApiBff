using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.Response;

[ExcludeFromCodeCoverage]
public class TempoResponse
{
    public string WeatherText { get; set; }
    public int WeatherIcon { get; set; }
    public bool IsDayTime { get; set; }
    public string Temperature { get; set; }
}