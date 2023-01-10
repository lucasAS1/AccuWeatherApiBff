using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.Response;

[ExcludeFromCodeCoverage]
public class TempoResponse
{
    public readonly string? WeatherText;
    public readonly int WeatherIcon;
    public readonly bool IsDayTime;
    public readonly string? Temperature;
}