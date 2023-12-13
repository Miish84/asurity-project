using ContactApi.Data;

namespace ContactApi.Repositories
{
    public interface IContactRepository
    {
        Contact GetById(int id);
        Contact GetByUuid(Guid uuid);
        IEnumerable<Contact> Get();
        bool Create(Contact contact);
        bool Update(Contact contact);
        bool Delete(int id);
    }
}
