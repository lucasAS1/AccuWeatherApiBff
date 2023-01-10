using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.Response;

[ExcludeFromCodeCoverage]
public class TempoResponse
{
    public string WeatherText;
    public int WeatherIcon;
    public bool IsDayTime;
    public string Temperature;
}