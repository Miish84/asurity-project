using AutoMapper;
using ContactApi.Data.Models;

namespace ContactApi.Mappings
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps() { 
            CreateMap<Dtos.Contact, Domain.Models.Contact>();
            CreateMap<Domain.Models.Contact, Dtos.Contact>();
            CreateMap<Domain.Models.Contact, Contact>();
            CreateMap<Contact, Domain.Models.Contact>();
        }
    }
}
