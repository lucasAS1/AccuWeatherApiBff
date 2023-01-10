using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class AdministrativeArea
{
    public string ID;
    public string LocalizedName;
    public string EnglishName;
    public int Level;
    public string LocalizedType;
    public string EnglishType;
    public string CountryID;
}