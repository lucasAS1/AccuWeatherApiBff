using AccuWeather.BFF.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.BFF.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IAccuWeatherService _accuWeatherService;

    public WeatherForecastController( IAccuWeatherService accuWeatherService)
    {
        _accuWeatherService = accuWeatherService;
    }

    [HttpGet("GetCityAndCurrentCondition")]
    public async Task<IActionResult> GetCityAndCurrentCondition([FromQuery]string cityName)
    {
        var cityResponse = await _accuWeatherService.GetCitiesByTextAsync(cityName);
        var result = await _accuWeatherService.GetCurrentConditionsByLocationKeyAsync(cityResponse.First().CityKey);
        
        return new JsonResult(result);
    }
    
    [HttpGet("GetCityCurrentCondition")]
    public async Task<IActionResult> GetCityCurrentCondition([FromQuery]string cityKey)
    {
        var result = await _accuWeatherService.GetCurrentConditionsByLocationKeyAsync(cityKey);
        
        return new JsonResult(result);
    }

    [HttpGet("GetCityKey")]
    public async Task<IActionResult> GetCityKey([FromQuery]string cityName)
    {
        var result = await _accuWeatherService.GetCitiesByTextAsync(cityName);
        
        return new JsonResult(result);
    }
}