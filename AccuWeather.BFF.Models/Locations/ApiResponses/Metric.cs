using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Metric
{
    public readonly double Value;
    public readonly string? Unit;
    public readonly int UnitType;
}
