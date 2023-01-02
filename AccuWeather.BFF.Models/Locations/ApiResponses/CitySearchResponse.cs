namespace AccuWeather.BFF.Models.Locations.ApiResponses;

public class CitySearchResponse
{
    public int Version { get; set; }
    public string Key { get; set; }
    public string Type { get; set; }
    public int Rank { get; set; }
    public string LocalizedName { get; set; }
    public string EnglishName { get; set; }
    public string PrimaryPostalCode { get; set; }
    public Region Region { get; set; }
    public Country Country { get; set; }
    public AdministrativeArea AdministrativeArea { get; set; }
}