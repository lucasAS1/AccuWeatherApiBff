using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Metric
{
    public double Value;
    public string Unit;
    public int UnitType;
}
