using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Region
{
    public string? ID { get; set; }
    public string? LocalizedName { get; set; }
    public string? EnglishName { get; set; }
}