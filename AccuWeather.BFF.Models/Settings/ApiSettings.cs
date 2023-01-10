using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Settings;

[ExcludeFromCodeCoverage]
public class ApiSettings
{
    public readonly string? ApiToken;
    public readonly string? UrlAccuWeather;
}