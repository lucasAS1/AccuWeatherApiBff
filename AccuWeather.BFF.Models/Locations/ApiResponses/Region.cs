using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Region
{
    public readonly string? ID;
    public readonly string? LocalizedName;
    public readonly string? EnglishName;
}