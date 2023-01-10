using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Imperial
{
    public readonly double Value;
    public readonly string Unit;
    public readonly int UnitType;
}