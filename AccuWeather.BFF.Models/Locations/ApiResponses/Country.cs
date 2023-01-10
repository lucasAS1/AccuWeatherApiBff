using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.ApiResponses;

[ExcludeFromCodeCoverage]
public class Country
{
    public string ID;
    public string LocalizedName;
    public string EnglishName;
}