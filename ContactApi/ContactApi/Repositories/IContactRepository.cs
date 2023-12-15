using ContactApi.Data.Models;

namespace ContactApi.Repositories
{
    public interface IContactRepository
    {
        Contact GetByUuid(Guid uuid);
        IEnumerable<Contact> Get();
        bool Create(Contact contact);
        bool Update(Contact contact);
        bool Delete(string uuid);
        int NextId();
    }
}
