using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Metric
{
    public double Value { get; set; }
    public string Unit { get; set; }
    public int UnitType { get; set; }
}
