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
            var contacts = _dbContext.Contacts.ToList();
            contacts.Add(contact);
            _dbContext.QueueChanges(contacts);
            return true;
        }

        public bool Update(Contact contact)
        {
            var contacts = _dbContext.Contacts.ToList();
            int index = contacts.FindIndex(c => c.Uuid.ToString() == contact.Uuid.ToString());
            var dbContact = contacts[index];
            contacts.RemoveAt(index);
            contacts.Add(contact);
            _dbContext.QueueChanges(contacts);
            return true;
        }

        // Wouldn't normally need to do this, but since we're not dealing with a real db
        public int NextId()
        {
            return _dbContext.Contacts.Count();
        }
    }
}
