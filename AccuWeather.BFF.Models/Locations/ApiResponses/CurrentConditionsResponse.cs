using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class CurrentConditionsResponse
{
    public readonly DateTime LocalObservationDateTime;
    public readonly int EpochTime;
    public readonly string WeatherText;
    public readonly int WeatherIcon;
    public readonly bool HasPrecipitation;
    public readonly object PrecipitationType;
    public readonly bool IsDayTime;
    public readonly Temperature Temperature;
    public readonly string MobileLink;
    public readonly string Link;
}