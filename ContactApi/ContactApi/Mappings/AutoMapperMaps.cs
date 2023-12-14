using AutoMapper;
using ContactApi.Data.Models;

namespace ContactApi.Mappings
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps() {
            CreateMap<Dtos.Contact, Domain.Models.Contact>();
            //.ForMember(src => src.Uuid, conf => conf.MapFrom(dest => new Guid(dest.Uuid)));
            CreateMap<Domain.Models.Contact, Dtos.Contact>();
                //.ForMember(src => src.Uuid, conf => conf.MapFrom(dest => dest.Uuid.ToString()));
            CreateMap<Domain.Models.Contact, Contact>();
            CreateMap<Contact, Domain.Models.Contact>();
        }
    }
}
