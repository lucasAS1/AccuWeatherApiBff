using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class CitySearchResponse
{
    public readonly int? Version;
    public readonly string? Key;
    public readonly string? Type;
    public readonly int? Rank;
    public readonly string? LocalizedName;
    public readonly string? EnglishName;
    public readonly string? PrimaryPostalCode;
    public readonly Region? Region;
    public readonly Country? Country;
    public readonly AdministrativeArea? AdministrativeArea;
}