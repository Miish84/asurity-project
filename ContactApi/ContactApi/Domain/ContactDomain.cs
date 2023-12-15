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
            var success = _unitOfWork.Contacts.Delete(uuid);

            if(!success)
            {
                throw new Exception("Unable to delete contact");
            }

            _unitOfWork.Commit();
        }

        public IEnumerable<Models.Contact> Create(Models.Contact contact)
        {
            Contact dataContact = new Contact(_unitOfWork.Contacts.NextId(), contact.Uuid, contact.FirstName, contact.LastName, contact.Email, contact.Street, contact.City, contact.State, contact.Zip, contact.Frequency);
            var success = _unitOfWork.Contacts.Create(dataContact);

            if (!success)
            {
                throw new Exception("Unable to create contact");
            }

            _unitOfWork.Commit();

            // Would not normally do this, but since I'm not working with an ORM this is a bit easier to manage
            return Get();
        }

        public IEnumerable<Models.Contact> Update(Models.Contact contact)
        {
            Contact dataContact = _mapper.Map<Contact>(contact);
            var success = _unitOfWork.Contacts.Update(dataContact);

            if (!success)
            {
                throw new Exception("Unable to update contact");
            }

            _unitOfWork.Commit();

            // Would not normally do this, but since I'm not working with an ORM this is a bit easier to manage
            return Get();
        }
    }
}
