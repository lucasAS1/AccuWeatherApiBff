using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class CurrentConditionsResponse
{
    public DateTime LocalObservationDateTime { get; set; }
    public int EpochTime { get; set; }
    public string WeatherText { get; set; }
    public int WeatherIcon { get; set; }
    public bool HasPrecipitation { get; set; }
    public object PrecipitationType { get; set; }
    public bool IsDayTime { get; set; }
    public Temperature Temperature { get; set; }
    public string MobileLink { get; set; }
    public string Link { get; set; }
}