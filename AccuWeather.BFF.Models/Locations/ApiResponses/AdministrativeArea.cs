using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class AdministrativeArea
{
    public readonly string? ID;
    public readonly string? LocalizedName;
    public readonly string? EnglishName;
    public readonly int Level;
    public readonly string? LocalizedType;
    public readonly string? EnglishType;
    public readonly string? CountryID;
}