using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Imperial
{
    public double Value;
    public string Unit;
    public int UnitType;
}