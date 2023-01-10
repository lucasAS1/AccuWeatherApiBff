using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Country
{
    public readonly string? ID;
    public readonly string? LocalizedName;
    public readonly string? EnglishName;
}