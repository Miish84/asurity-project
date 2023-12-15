using ContactApi.Domain.Models;

namespace ContactApi.Domain
{
    public interface IContactDomain
    {
        public IEnumerable<Contact> Get();
        public Contact GetByUuid(string uuid);
        public void Delete(string uuid);
        public IEnumerable<Contact> Create(Contact contact);
        public IEnumerable<Contact> Update(Contact contact);
    }
}
