using ContactApi.Data;
using ContactApi.Repositories;
using AutoMapper;
using ContactApi.Data.Models;

namespace ContactApi.Domain
{
    public class ContactDomain : IContactDomain
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

        public Models.Contact GetByUuid(string uuid)
        {
            var guid = new Guid(uuid);
            Contact contact = _unitOfWork.Contacts.GetByUuid(guid);
            return _mapper.Map<Models.Contact>(contact);
        }

        public void Delete(string uuid)
        {
            var guid = new Guid(uuid);
            var success = _unitOfWork.Contacts.Delete(guid);

            if(!success)
            {
                throw new Exception("Unable to delete contact");
            }
        }
    }
}
