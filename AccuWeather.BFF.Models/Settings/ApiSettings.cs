using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Settings;

[ExcludeFromCodeCoverage]
public class ApiSettings
{
    public string ApiToken { get; set; }
    public string UrlAccuWeather { get; set; }
}