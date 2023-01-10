using System.Diagnostics.CodeAnalysis;
using AccuWeather.BFF.Agents;
using AccuWeather.BFF.Interfaces.Agents;
using AccuWeather.BFF.Interfaces.Services;
using AccuWeather.BFF.Services;
using Autofac;

namespace AccuWeather.BFF.WebApi.DI;

[ExcludeFromCodeCoverage]
public class IocModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        ConfigureInfrastructureLayer(builder);
        ConfigureDomainLayer(builder);
    }

    private static void ConfigureInfrastructureLayer(ContainerBuilder builder)
    {
        builder.RegisterType<AccuWeatherApiAgent>().As<IAccuWeatherApiAgent>();
    }

    private static void ConfigureDomainLayer(ContainerBuilder builder)
    {
        builder.RegisterType<AccuWeatherService>().As<IAccuWeatherService>();
    }
}