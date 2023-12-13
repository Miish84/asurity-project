using ContactApi.Data;
using ContactApi.Repositories;
using AutoMapper;

namespace ContactApi.Domain
{
    public class ContactDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactDomain(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork= unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Models.Contact> Get()
        {
            IEnumerable<Contact> contacts = _unitOfWork.Contacts.Get();
            return _mapper.Map<IEnumerable<Models.Contact>>(contacts);
        }

        // Implement business logic methods using the repository
    }
}
