using Application.Feature.Store;
using AutoMapper;
using Entities;

namespace API.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Store, HentStoresDto>();
            CreateMap<ChainInfo, ChainInfoDto>().ReverseMap();
            CreateMap<InStoreServices, InStoreServicesDto>().ReverseMap();
            CreateMap<OpeningHours, OpeningHoursDto>().ReverseMap();
            CreateMap<OpeningHours, OpeningHoursDto>().ReverseMap();
        }
    }
}
