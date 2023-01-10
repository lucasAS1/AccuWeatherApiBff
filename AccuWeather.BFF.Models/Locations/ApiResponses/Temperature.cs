using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Temperature
{
    public readonly Metric Metric;
    public readonly Imperial Imperial;
}