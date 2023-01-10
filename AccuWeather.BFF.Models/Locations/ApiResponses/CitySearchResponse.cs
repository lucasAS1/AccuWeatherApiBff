using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class CitySearchResponse
{
    public int Version;
    public string Key;
    public string Type;
    public int Rank;
    public string LocalizedName;
    public string EnglishName;
    public string PrimaryPostalCode;
    public Region Region;
    public Country Country;
    public AdministrativeArea AdministrativeArea;
}