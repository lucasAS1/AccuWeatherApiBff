using System.Diagnostics.CodeAnalysis;
using AccuWeather.BFF.Models.Locations.ApiResponses;
using AccuWeather.BFF.Models.Locations.Response;
using AutoMapper;

namespace AccuWeather.BFF.Agents.Mapping;

[ExcludeFromCodeCoverage]
public class InfraDataPersistenceProfile : Profile
{
    public InfraDataPersistenceProfile()
    {
        MappingLocation();
        MappingCurrentConditions();
    }

    private void MappingLocation()
    {
        CreateMap<CitySearchResponse, CidadeResponse>(MemberList.None)
            .ForMember(dest => dest.CityKey, opts => opts.MapFrom(source => source.Key))
            .ForMember(dest => dest.CityName, opts => opts.MapFrom(source => source.LocalizedName))
            .ReverseMap();
    }
    
    private void MappingCurrentConditions()
    {
        CreateMap<CurrentConditionsResponse, TempoResponse>(MemberList.None)
            .ForMember(
                dest => dest.Temperature,
                opts => opts.MapFrom(source => source.Temperature.Metric.Value))
            .ReverseMap();
    }
}