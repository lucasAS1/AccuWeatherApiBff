using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Temperature
{
    public Metric Metric { get; set; }
    public Imperial Imperial { get; set; }
}