using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.Response;

[ExcludeFromCodeCoverage]
public class CidadeResponse
{
    public readonly string CityKey;
    public readonly string CityName;
}