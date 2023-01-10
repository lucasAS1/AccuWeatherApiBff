using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class CurrentConditionsResponse
{
    public DateTime LocalObservationDateTime;
    public int EpochTime;
    public string WeatherText;
    public int WeatherIcon;
    public bool HasPrecipitation;
    public object PrecipitationType;
    public bool IsDayTime;
    public Temperature Temperature;
    public string MobileLink;
    public string Link;
}