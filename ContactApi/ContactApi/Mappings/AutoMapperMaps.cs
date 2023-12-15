using AutoMapper;
using ContactApi.Data.Models;

namespace ContactApi.Mappings
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps() {
            // Contacts
            CreateMap<Dtos.Contact, Domain.Models.Contact>()
            .ForMember(src => src.Uuid, conf => conf.MapFrom((dest) => String.IsNullOrEmpty(dest.Uuid) ?  Guid.NewGuid() : Guid.Parse(dest.Uuid) ));
            CreateMap<Domain.Models.Contact, Dtos.Contact>();
            CreateMap<Domain.Models.Contact, Contact>();
            CreateMap<Contact, Domain.Models.Contact>();

            // Lookups
            CreateMap<State, Dtos.State>();
            CreateMap<ContactFrequency, Dtos.ContactFrequency>();
        }
    }
}
