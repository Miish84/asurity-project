using ContactApi.Data;
using ContactApi.Data.Models;
using System;

namespace ContactApi.Repositories
{
    public class ContactRepository: IContactRepository
    {
        private readonly MockDbContext _dbContext;
        public ContactRepository(MockDbContext dbContext) {
            _dbContext = dbContext;
        }
        public IEnumerable<Contact> Get()
        {
            return _dbContext.Contacts.ToList();
        }

        public Contact GetByUuid(Guid uuid)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(x => x.Uuid == uuid);
            return contact;
        }

        public bool Delete(string uuid)
        {
            var contacts = _dbContext.Contacts.Where(x => x.Uuid.ToString() != uuid).ToList();
            _dbContext.QueueChanges(contacts);
            return true;
        }

        public bool Create(Contact contact)
        {
            throw new NotImplementedException();
        }




        public bool Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
