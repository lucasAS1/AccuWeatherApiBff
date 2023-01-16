﻿using System.Diagnostics.CodeAnalysis;

namespace AccuWeather.BFF.Models.Locations.Response;

[ExcludeFromCodeCoverage]
public class CidadeResponse
{
    public string CityKey { get; set; }
    public string CityName { get; set; }
}