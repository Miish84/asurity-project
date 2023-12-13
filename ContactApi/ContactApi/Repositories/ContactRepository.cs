using ContactApi.Data;

namespace ContactApi.Repositories
{
    public class ContactRepository: IContactRepository
    {

        public ContactRepository() { }

        public bool Create(Contact contact)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> Get()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Contact GetByUuid(Guid uuid)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
