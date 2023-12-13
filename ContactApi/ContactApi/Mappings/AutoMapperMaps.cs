using AutoMapper;

namespace ContactApi.Mappings
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps() { 
            CreateMap<View.Contact, Domain.Models.Contact>();
            CreateMap<Domain.Models.Contact, View.Contact>();
            CreateMap<Domain.Models.Contact, Data.Contact>();
            CreateMap<Data.Contact, Domain.Models.Contact>();
        }
    }
}
